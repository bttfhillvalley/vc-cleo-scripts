  �ONERAD       M ����9�   M �����
FEA_FM0 9�  M �����
FEA_FM1 9�  M �����
FEA_FM2 9�  M o����
FEA_FM3 9�  M S����
FEA_FM4 9�  M 7����
FEA_FM5 9�  M ����
FEA_FM6 9�  M �����
FEA_FM7 9�  M �����
FEA_FM8   V M �����  M �����  �
  
  <�
   	 M ����    M w����     M���    M ����  	�
`�_      �   � ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  {$CLEO .s}
0000:
thread 'onerad'
int RADIOID
int RENAME = 1

0019:   RENAME > 0 
jf @OneRadio 
8039:   NOT RADIOID == 0
jf @Rename1
0ADF: add_dynamic_GXT_entry "FEA_FM0" text " "

:Rename1
8039:   NOT RADIOID == 1
jf @Rename2
0ADF: add_dynamic_GXT_entry "FEA_FM1" text " "

:Rename2
8039:   NOT RADIOID == 2
jf @Rename3
0ADF: add_dynamic_GXT_entry "FEA_FM2" text " "

:Rename3
8039:   NOT RADIOID == 3
jf @Rename4
0ADF: add_dynamic_GXT_entry "FEA_FM3" text " "

:Rename4
8039:   NOT RADIOID == 4
jf @Rename5
0ADF: add_dynamic_GXT_entry "FEA_FM4" text " "

:Rename5
8039:   NOT RADIOID == 5
jf @Rename6
0ADF: add_dynamic_GXT_entry "FEA_FM5" text " "

:Rename6
8039:   NOT RADIOID == 6
jf @Rename7
0ADF: add_dynamic_GXT_entry "FEA_FM6" text " "

:Rename7
8039:   NOT RADIOID == 7
jf @Rename8
0ADF: add_dynamic_GXT_entry "FEA_FM7" text " "

:Rename8
8039:   NOT RADIOID == 8
jf @OneRadio
0ADF: add_dynamic_GXT_entry "FEA_FM8" text " "

:OneRadio
wait 0
   Player.Defined($PLAYER_CHAR)
jf @OneRadio   
00E0: player $PLAYER_CHAR driving
jf @OneRadio
03C1: RENAME = player $PLAYER_CHAR car_no_save 
0A97: RENAME = car RENAME struct
000A: RENAME += 0x23C // current radio station
0A8D: RENAME = read_memory RENAME size 1 virtual_protect 1 
001B:   9 > RENAME
jf @OneRadio
001D:   RADIOID > RENAME
jf @OneRadio_2
0085: RENAME = RADIOID // Set the only radio station
jump @OneRadio_Set

:OneRadio_2
001D:   RENAME > RADIOID
jf @OneRadio
0006: RENAME = 9 // Radio off
0AA5: call 0x5F9960 num_params 2 pop 0 0.0 177 // Radio off sound

:OneRadio_Set
041E: set_radio_station RENAME -1
jump @OneRadio�  __SBFTR 