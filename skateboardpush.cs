  �  9    M m����
SKATEBOARDPUSH.CS   �  �  M t����   �      M t���A   �  9  �M t����  M t���   ���� ����  T     �  �
     zD   M U���A   � 9  �9   M x����
   �
 � �
 �  l   �     M x����
   
  ��
   �   � �  �  M x����  !      M x����
N���  �   �@  ��     zD  M :��� m����   
  L�   �@V@      �
  VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  {$cleo}
{$USE ini}   
0000:
if 0@ == 0
then
0A92: stream_custom_script "skateboardpush.cs" 1 
while true
wait 0 
if 
00DF:   actor $player_actor driving
then
03C0: 0@ = actor $player_actor car
if 
0@ > 0
then  
0441: 1@ = car 0@ model
if
0039: 1@ == 4796 
then                   
while 00DF:   actor $player_actor driving
wait 0
end
end
end
end
end 
end

while true
    wait 0                 
    0054: store_player 0 position_to 11@ 12@ 13@
    if 0AE2: 0@ = random_vehicle_near_point 11@ 12@ 13@ in_radius 1000.0 find_next 0 pass_wrecked 1
    then
        repeat       
            0441: 1@ = car 0@ model
            if or
            0039: 1@ == 4796 
            0039: 1@ == 14@
            then      
                0A97: 5@ = car 0@ struct
                0A8E: 1@ = 5@ + 0x1F9
                0A8C: write_memory 1@ size 1 value 168 virtual_protect 0
               046C: 2@ = car 0@ driver 
                if 2@ > 0
                then
                    0A97: 1@ = car 0@ struct
                    1@ += 0x1F0
                    0A8D: 1@ = read_memory 1@ size 4 virtual_protect 0
                    02E3: 16@ = car 0@ speed
                    if and
                    81F3:   not car 0@ airborne

                    00E1:   player 0 pressed_button 16
                    then   
                    if 1@ > 0.0  
                    then    
                        0AB1: cleo_call @PlayAnim 4 _pedHandle 2@ _assocGroupId 0 _animationId 154 _blendFactor 4.0
                    end  
                   end  
                end  
            end  
        wait 1500
        until 8AE2: not 0@ = random_vehicle_near_point 11@ 12@ 13@ in_radius 1000.0 find_next 1 pass_wrecked 1
    end
end     
     
:PlayAnim
05E6: 4@ = actor 0@ struct
4@ += 0x4C
05E0: 4@ = read_memory 4@ size 4 virtual_protect 0
05E1: call 0x405640 num_params 4 pop 4 _blendFactor 3@ _animationId 2@ _assocGroupId 1@ _rwObject 4@  
0AB2: cleo_return 0

�  __SBFTR 