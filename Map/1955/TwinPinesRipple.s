  �PINECHK   �
m �
n � � � M ����� f f M �����
o �
MAP/NEWSPAPERS/UFO_NEWS.S�S*�S*  ���� f f M 9����
o�
MAP/NEWSPAPERS/UFO_NEWS.S�S*�S*  ����
o�
MAP/NEWSPAPERS/55_NEWS.S�O*�S*  ����VAR '   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_ASS1_RUB_OUT �   PASSED_KENT1_DEATH_ROW �   PASSED_TEX1_FOUR_IRON �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PLAYER_CHAR    PLAYER_ACTOR    DEFAULT_WAIT_TIME    ONMISSION 9  CUT_SCENE_TIME |   CURRENT_TIME_IN_MS �  ARENA_DOOR_1    ARENA_DOOR_2    FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   FILM_STUDIO_BACK_GATE_OPEN   PRINT_WORKS_ASSET �  CAR_SHOWROOM_ASSET �  FILM_STUDIO_ASSET �  ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   FLAG   SRC �  {$CLEO .s}
{$INCLUDE ../../Common/CleoConstants.txt}
int local_mall_sign
int local_PINE1
int local_PINE2
int current_date

:TwinPinesRipple
0000:
thread 'pinechk'

:TwinPinesCheck
wait 0
0AB4: local_PINE1 = var PINE1
0AB4: local_PINE2 = var PINE2 
if and
03CA:   object local_PINE1 exists
03CA:   object local_PINE2 exists
else_jump @TwinPinesCheck 
if and 
    0366:   object local_PINE1 damaged
    0366:   object local_PINE2 damaged
then
    0AB3: var mall_sign = 0 //- no Pine
        stream_custom_script "Map/newspapers/UFO_News.s" 19551106 19551112
else if or 
    0366:   object local_PINE1 damaged
    0366:   object local_PINE2 damaged
then
    0AB3: var mall_sign = 1 //- Lone Pine
    stream_custom_script "Map/newspapers/UFO_News.s" 19551106 19551112
else
    0AB3: var mall_sign = 2 //- Twin Pine
    stream_custom_script "Map/newspapers/55_News.s" 19550101 19551112
end
end
jump @TwinPinesCheck       

�   __SBFTR 