  �MAP &   �
MAP/1985/MALLCLOCK.S �
MAP/COMMON/DOCDOOR.S �
MAP/COMMON/BARBERPOLE.S �
 �
o  �
o9  �M y��� 
 ����	?1885	?1955	?1985	?20158?18858?19558?19858?2015P �����
 �  )� �q#M ����?18857?1885P S����     ���� �����  )� % .M 8���?19557?1955�
 MAP/NEWSPAPERS/CLOCKTOWER_NEWS.S�S*% . P �����
MAP/1955/TWINPINESRIPPLE.S �
MAP/1955/BARNPROPS.S�q#% . �   ? o��� �����  )� �2M ����?19857?1985P ����P ����
MAP/1985/DOGFOOD.S �333? ��� ����?20157?2015P ����P ����P ����fff? �����
   �  )  �q#M ����	?18858?1885 2����
   � )� �q#)  % .M o���	?19558?1955YCTNEWS  P >��� 2����
   � )� % .)  �2M ���	?19858?1985P ���� 2����
   �  )� �2M ����	?20158?2015P V���P ���� 2����N͌�)\�C�QA �N���u�C�QA �
m �
n w   �Bw   ��Q YPINECHK YUFONEW    Q �
o  �  9    M ����?NOPINE �����  9   M ����?LONEPINE ����?TWINPINEQ 	?NOPINE	?LONEPINE	?TWINPINEQ 	 
?  PARTICLENEWSPAPER01_64NEWSPAPER01_64 	 
?  PARTICLEGAMELEAF01_64GAMELEAF01_64 	 
?  PARTICLEGAMELEAF02_64GAMELEAF02_64 Q 
?  PARTICLENEWSPAPER01_64NEWSPAPER01_64
?  PARTICLEGAMELEAF01_64GAMELEAF01_64	 
?  PARTICLEGAMELEAF02_64GAMELEAF02_64 Q 
?  PARTICLENEWSPAPER01_64NEWSPAPER01_64	
?  PARTICLEGAMELEAF01_64GAMELEAF01_64 
?  PARTICLEGAMELEAF02_64GAMELEAF02_64 Q 
?  STATLERSMWALL9SMWALL
?  STATLERSMWALL10SMWALL
?  STATLERSMWALL11SMWALL
?  STATLERSMWALL13SMWALL
?  STATLERSMWIN5SMWIN
?  STATLERSMWIN6SMWIN
?  STATLERSMWALL1SMWALL
?  STATLERSMWALL4SMWALL
?  STATLERSMWALL5SMWALL
?  STATLERSMWALL6SMWALL
?  STATLERSMWALL7SMWALLQ 
?  STATLERSMWALL9SMWALL
?  STATLERSMWALL10SMWALL
?  STATLERSMWALL11SMWALL
?  STATLERSMWALL13SMWALL
?  STATLERSMWIN5SMWIN
?  STATLERSMWIN6SMWIN	
?  STATLERSMWALL1SMWALL
?  STATLERSMWALL4SMWALL
?  STATLERSMWALL5SMWALL
?  STATLERSMWALL6SMWALL
?  STATLERSMWALL7SMWALLQ VAR '   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_ASS1_RUB_OUT �   PASSED_KENT1_DEATH_ROW �   PASSED_TEX1_FOUR_IRON �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PLAYER_CHAR    PLAYER_ACTOR    DEFAULT_WAIT_TIME    ONMISSION 9  CUT_SCENE_TIME |   CURRENT_TIME_IN_MS �  ARENA_DOOR_1    ARENA_DOOR_2    FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   FILM_STUDIO_BACK_GATE_OPEN   PRINT_WORKS_ASSET �  CAR_SHOWROOM_ASSET �  FILM_STUDIO_ASSET �  ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   FLAG   SRC �  {$CLEO .cs}
0000:
thread 'MAP'

{$INCLUDE Common/CleoConstants.txt}
int local_mall_sign
int local_PINE1
int local_PINE2
int current_date
int paper
int paper2
int paper3 
//int 0@

:DateCheckStart
//03C1: 0@ = player $PLAYER_CHAR car
stream_custom_script "Map/1985/MallClock.s" //clock
stream_custom_script "Map/common/DocDoor.s"
stream_custom_script "Map/common/BarberPole.s"
0AB3: current_date = var CDATE
0AB4: local_mall_sign = var mall_sign
0AB3: var mall_sign = 2 //- Twin Pine
while current_date == -1
    wait 10
end
3F09: remove_build "1885"
3F09: remove_build "1955"
3F09: remove_build "1985"
3F09: remove_build "2015"
3F38: remove_objects "1885"
3F38: remove_objects "1955"
3F38: remove_objects "1985"
3F38: remove_objects "2015" 
gosub @MallSignDestroy


:DateCheck
//gosub @reset_trash
0AB4: current_date = var CDATE
if
    current_date < 19100101
then
    3F08: add_build "1885"
    3F37: add_objects "1885"
    gosub @1885_News
    01EB: set_traffic_density_multiplier_to 0.0
    jump @WaitToLeave1885
else if
    current_date < 19800101
then
    3F08: add_build "1955"
    3F37: add_objects "1955"
    stream_custom_script "Map/newspapers/Clocktower_News.s" 19551113 19800101
    gosub @TwinpinesTreesCreate
    stream_custom_script "map/1955/TwinPinesRipple.s"
    stream_custom_script "map/1955/BarnProps.s" 19100101 19800101
    01EB: set_traffic_density_multiplier_to 0.5
    jump @WaitToLeave1955
else if
    current_date < 20100101
then
    3F08: add_build "1985"
    3F37: add_objects "1985"
    gosub @1985_News
    gosub @MallSignCreate  
    stream_custom_script "map/1985/DogFood.s"
    01EB: set_traffic_density_multiplier_to 0.7
    jump @WaitToLeave1985
else   
    3F08: add_build "2015"
    3F37: add_objects "2015"
    gosub @2015_News 
    gosub @2015_Textures 
    gosub @MallSignCreate 
    01EB: set_traffic_density_multiplier_to 0.9 
    jump @WaitToLeave2015
end
end
end

:WaitToLeave1885
0AB4: current_date = var CDATE
wait 0
if
    current_date >= 19100101
else_jump @WaitToLeave1885
3F09: remove_build "1885"
3F38: remove_objects "1885"
jump @DateCheck

:WaitToLeave1955
0AB4: current_date = var CDATE
wait 0
if or
    current_date < 19100101
    current_date >= 19800101 // We traveled to the present/future
else_jump @WaitToLeave1955
3F09: remove_build "1955"
3F38: remove_objects "1955"
end_thread_named 'CTNEWS'
gosub @TwinPinesTreesDestroy
jump @DateCheck

:WaitToLeave1985
0AB4: current_date = var CDATE
wait 0
if or
  current_date < 19800101 // We traveled back to the past
  current_date >= 20100101 // We traveled to the future
else_jump @WaitToLeave1985
3F09: remove_build "1985"
3F38: remove_objects "1985"
gosub @MallSignDestroy
jump @DateCheck

:WaitToLeave2015
0AB4: current_date = var CDATE
wait 0
if
  current_date < 20100101 // We traveled to the past/present
else_jump @WaitToLeave2015
3F09: remove_build "2015"
3F38: remove_objects "2015" 
gosub @Texture_Reset
gosub @MallSignDestroy  
jump @DateCheck

:TwinPinesTreesCreate 
local_PINE1 = Object.Init(6990,  -518.2, 276.72, 13.07)
local_PINE2 = Object.Init(6990,  -519.33, 276.92, 13.07)
0AB3: var PINE1 = local_PINE1
0AB3: var PINE2 = local_PINE2
Object.Angle(local_PINE1) = 80.0
Object.Angle(local_PINE2) = -100.0
return

:TwinPinesTreesDestroy
end_thread_named 'pinechk'
end_thread_named 'ufonew'
0108: destroy_object local_PINE1
0108: destroy_object local_PINE2
return

:MallSignCreate
0AB4: local_mall_sign = var mall_sign
if
    local_mall_sign == 0
then
    3F08: add_build "nopine"
else if
    local_mall_sign == 1
then
    3F08: add_build "lonepine"
else
    3F08: add_build "twinpine"
end
end
return

:MallSignDestroy
3F09: remove_build "nopine"
3F09: remove_build "lonepine"
3F09: remove_build "twinpine"
return

:1985_News 
0209: paper = random_int_in_ranges 1 6 //1 = blank 2 = blue 3 = white
3F0A: car 0@ replace_tex "particle" "newspaper01_64" with "newspaper01_64" index paper
0209: paper2 = random_int_in_ranges 1 6 //1 = blank 2 = pink 3 = yellow
3F0A: car 0@ replace_tex "particle" "gameleaf01_64" with "gameleaf01_64" index paper2
0209: paper3 = random_int_in_ranges 4 6 // 4 = george 6 = doc
3F0A: car 0@ replace_tex "particle" "gameleaf02_64" with "gameleaf02_64" index paper3
return

:2015_News
3F0A: car 0@ replace_tex "particle" "newspaper01_64" with "newspaper01_64" index 1
3F0A: car 0@ replace_tex "particle" "gameleaf01_64" with "gameleaf01_64" index 1
0209: paper = random_int_in_ranges 2 4 //1 = blank 2 = youth 3 = gang
3F0A: car 0@ replace_tex "particle" "gameleaf02_64" with "gameleaf02_64" index paper
return

:1885_News
3F0A: car 0@ replace_tex "particle" "newspaper01_64" with "newspaper01_64" index 9
3F0A: car 0@ replace_tex "particle" "gameleaf01_64" with "gameleaf01_64" index 0
3F0A: car 0@ replace_tex "particle" "gameleaf02_64" with "gameleaf02_64" index 0
return   



:2015_Textures
//STATLER 2015
3F0A: car 0@ replace_tex "statler" "SMWALL9" with "SMWALL" index 18
3F0A: car 0@ replace_tex "statler" "SMWALL10" with "SMWALL" index 18
3F0A: car 0@ replace_tex "statler" "SMWALL11" with "SMWALL" index 18
3F0A: car 0@ replace_tex "statler" "SMWALL13" with "SMWALL" index 18
3F0A: car 0@ replace_tex "statler" "SMWIN5" with "SMWIN" index 7
3F0A: car 0@ replace_tex "statler" "SMWIN6" with "SMWIN" index 7
3F0A: car 0@ replace_tex "statler" "SMWALL1" with "SMWALL" index 8
3F0A: car 0@ replace_tex "statler" "SMWALL4" with "SMWALL" index 8
3F0A: car 0@ replace_tex "statler" "SMWALL5" with "SMWALL" index 8
3F0A: car 0@ replace_tex "statler" "SMWALL6" with "SMWALL" index 8
3F0A: car 0@ replace_tex "statler" "SMWALL7" with "SMWALL" index 8
return    

:Texture_Reset
3F0A: car 0@ replace_tex "statler" "SMWALL9" with "SMWALL" index 14
3F0A: car 0@ replace_tex "statler" "SMWALL10" with "SMWALL" index 15
3F0A: car 0@ replace_tex "statler" "SMWALL11" with "SMWALL" index 16
3F0A: car 0@ replace_tex "statler" "SMWALL13" with "SMWALL" index 17
3F0A: car 0@ replace_tex "statler" "SMWIN5" with "SMWIN" index 8
3F0A: car 0@ replace_tex "statler" "SMWIN6" with "SMWIN" index 9
3F0A: car 0@ replace_tex "statler" "SMWALL1" with "SMWALL" index 19
3F0A: car 0@ replace_tex "statler" "SMWALL4" with "SMWALL" index 19
3F0A: car 0@ replace_tex "statler" "SMWALL5" with "SMWALL" index 19
3F0A: car 0@ replace_tex "statler" "SMWALL6" with "SMWALL" index 19
3F0A: car 0@ replace_tex "statler" "SMWALL7" with "SMWALL" index 19
return	  __SBFTR 