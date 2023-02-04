      d  �
  � V �� �  �
R  �M ����   G� G �  � H� H M �����           �?   _               X   �           ��   � �    @�E i  � r  & 	 �      s  # 	 �  �       ��       E !            @�   �    r ���?  #?  � �   � *?  �  M X���� �
R  �M .���    X���� �    �M ����   �  9  M ����   ����              @�   �     @�E�    r ����           �?   _               X    l���$?  �           ��   r  & 	 �  *    s  # 	 �  I �  9  M ����� ����Zs�   ��  ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC !  {$CLEO .cs}
{$INCLUDE Common/CleoConstants.txt}
const
    DUMMY_CAR_MODEL = #SABRE
    KEY_RADIOCONTROL = 82 // R
end
0000:
int vehicle
int camera_mode = 15
int RC_MODEL = 100
float x
float y
float z
int dummy_vehicle
int dummy_actor
float player_angle
float player_health

:RadioControlStart
wait 0
0AB4: vehicle = var TIME_MACHINE
if and
    Player.Defined($PLAYER_CHAR)
    80E0:   not player $PLAYER_CHAR driving
    not Car.Wrecked(vehicle)
    is_key_pressed KEY_RADIOCONTROL // R
    //02D7:   player $PLAYER_CHAR current_weapon == 2
    timera > 500
else_jump @RadioControlStart
timera = 0
Model.Load(DUMMY_CAR_MODEL) //DMC-12
Model.Load(RC_MODEL) //RC REMOTE
038B: load_requested_models

:RadioControlLoadModels
wait 0
if and
    Model.Available(DUMMY_CAR_MODEL) //DMC-12
    Model.Available(RC_MODEL) //RC REMOTE
else_jump @RadioControlLoadModels

// Set camera first
04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 0.0 1.0
Camera.SetPosition(x, y, z, 0.0, 0.0, 0.0)
Camera.OnVehicle(vehicle, camera_mode, 1)

// Create Dummy car
04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 0.0 -1.0
dummy_vehicle = Car.Create(DUMMY_CAR_MODEL, x, y, 5000.0) //DMC-12
0369: put_player $PLAYER_CHAR in_car dummy_vehicle
02D4: car dummy_vehicle turn_off_engine

// Create Dummy Actor
player_angle = Actor.Angle($PLAYER_ACTOR)
player_health = Actor.Health($PLAYER_ACTOR)
009A: dummy_actor = create_actor_pedtype 4 model #NULL at x y z //player model
Actor.Angle(dummy_actor) = player_angle
Actor.Health(dummy_actor) = player_health
01B2: give_actor dummy_actor weapon rc_model ammo 1 // Load the weapon model before using this
04C4: create_coordinate x y z from_actor dummy_actor offset 0.0 -1.0 0.0
0245: set_actor dummy_actor walk_style_to 33

// Set initial Angle
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 -0.75
01BE: set_actor dummy_actor to_look_at_spot x y z
0372: set_actor dummy_actor anim 25 wait_state_time 99999999 ms

// Set Remote mode
3F03: car vehicle turn_on_engine
3F23: set_car vehicle remote
04D6: enable_rc_car_detonation 0
048A: enable_rc_vehicle_detonation 0

:RadioControlLoop
wait 0

if and
    3F2A:   is_player_in_remote_mode_with_car vehicle
    not Car.Wrecked(vehicle)
else_jump @RadioControlExit
if and
    is_key_pressed KEY_RADIOCONTROL
    timera > 500
then
    timera = 0
    jump @RadioControlExit
end
if and
    00E1:   player 0 pressed_button 13
    timera > 500
then
    timera = 0
    if
        camera_mode == 3
    then
        camera_mode = 15 // Tracking
    else
        camera_mode = 3 // Behind car
    end
end

// Keep track of Delorean and have the dummy car over it to keep cars loaded
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 -0.75
Car.PutAt(dummy_vehicle, x, y 5000.0)
01BE: set_actor dummy_actor to_look_at_spot x y z
0372: set_actor dummy_actor anim 25 wait_state_time 99999999 ms
04C4: create_coordinate x y z from_actor dummy_actor offset 0.0 0.0 1.0
Camera.SetPosition(x, y, z, 0.0, 0.0, 0.0)
Camera.OnVehicle(vehicle, camera_mode, 2)
jump @RadioControlLoop

:RadioControlExit
3F24: remove_car vehicle remote
04C4: create_coordinate x y z from_actor dummy_actor offset 0.0 0.0 -1.0
player_angle = Actor.Angle(dummy_actor)
player_health = Actor.Health(dummy_actor)
Actor.DestroyInstantly(dummy_actor)
012A: put_player $PLAYER_CHAR at x y z and_remove_from_car
Actor.Angle($PLAYER_ACTOR) = player_angle
Actor.Health($PLAYER_ACTOR) = player_health
Car.Destroy(dummy_vehicle)
Model.Destroy(RC_model)
if
    camera_mode == 3
then
    Camera.Restore_WithJumpCut
else
    Camera.Restore
end
Camera.SetBehindPlayer
Player.CanMove($PLAYER_CHAR) = False
wait 500
Player.CanMove($PLAYER_CHAR) = True
jump @RadioControlStart
@  __SBFTR 