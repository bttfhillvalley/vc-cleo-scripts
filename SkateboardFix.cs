   
�  V� M ���� �����  �� M ���� �����   �  �  M ����� �  ��  ��  ��  ��  ��  ��  ��  �M ,����   ��            �b     � ����� �  ��  ��  �M �����   ��            �b     � ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC Q  {$CLEO .cs}
{$INCLUDE Common/CleoConstants.txt}
int vehicle
float x
float y
float z 
0000:
while true
    wait 10
    if
        not Player.Defined($PLAYER_CHAR)
    then
        continue
    end
    if
        80E0:   not player $PLAYER_CHAR driving
    then
        continue
    end
    03C1: vehicle = player $PLAYER_CHAR car

if// and
00E1:   player 0 pressed_button 15 //exit vehicle

      //  timera > 500
then  
   // timera = 0      
if or
00DD:   actor $player_actor driving_vehicle_type 4796  //mattel
00DD:   actor $player_actor driving_vehicle_type 4797 //mattel handlebars
00DD:   actor $player_actor driving_vehicle_type 4798 //generic hoverboard
00DD:   actor $player_actor driving_vehicle_type 4799 //generic handlebars
00DD:   actor $player_actor driving_vehicle_type 4800 //question mark
00DD:   actor $player_actor driving_vehicle_type 4801 //no tech
00DD:   actor $player_actor driving_vehicle_type 4802 //pitbull
00DD:   actor $player_actor driving_vehicle_type 4803 //rising sun
then
04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset -1.0 0.0 0.0
wait 500
0362: put_actor $PLAYER_ACTOR at x y z and_remove_from_car
wait 500
else
if or
00DD:   actor $player_actor driving_vehicle_type 4804  //1955 skateboard
00DD:   actor $player_actor driving_vehicle_type 4805 //1955 handlebars
00DD:   actor $player_actor driving_vehicle_type 4806 //1985 skateboard
then
04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset -1.0 0.0 0.0
wait 500
0362: put_actor $PLAYER_ACTOR at x y z and_remove_from_car
wait 500

end
end
end
end
3  __SBFTR 