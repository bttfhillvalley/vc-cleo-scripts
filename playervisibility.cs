   
�  V� M ���� X���� �
�   �M X���   �  9    M �����
  �
�yH        X����  9   M X����
  �
�yH  �       ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  {$CLEO .cs}
{$INCLUDE Common/CleoConstants.txt}
0000:
int playervis
while true 
    wait 10
    if
        not Player.Defined($PLAYER_CHAR)
    then
        continue
    end

if and  
   is_key_pressed 145
    timera > 500
then 
timera = 0      

    if 
        playervis == 0
    then              
   0A96: 6@ = actor $PLAYER_ACTOR struct
0AA6: call_method 0x487990 struct 6@ num_params 1 pop 1 0 // Actor's visibility 0 to 255
playervis = 1
      
    else
       if 
        playervis == 1
    then  
        0A96: 6@ = actor $PLAYER_ACTOR struct
0AA6: call_method 0x487990 struct 6@ num_params 1 pop 1 255 // Actor's visibility 0 to 255
    playervis = 0   
           
end
end
end  
end�   __SBFTR 