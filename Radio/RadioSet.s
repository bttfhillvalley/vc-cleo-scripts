  �RADIOS    �
 � -    -�  M �����
RADIO/ONERADIO.S  �
FEA_FM01800 STATIC�
FEA_FM1
KKHV 1940S�
FEA_FM2
KKHV 1950S�
FEA_FM3
KKHV 1960S�
FEA_FM4107.9 HVR 1970S�
FEA_FM5107.9 HVR 1980S�
FEA_FM6107.9 HVR 1990S�
FEA_FM7REWIND FM 2000S�
FEA_FM8REWIND FM FUTURE  �
 � -�   -   M ����YONERAD  �
FEA_FM01800 STATIC�
FEA_FM1
KKHV 1940S�
FEA_FM2
KKHV 1950S�
FEA_FM3
KKHV 1960S�
FEA_FM4107.9 HVR 1970S�
FEA_FM5107.9 HVR 1980S�
FEA_FM6107.9 HVR 1990S�
FEA_FM7REWIND FM 2000S�
FEA_FM8REWIND FM FUTURE ����VAR '   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_ASS1_RUB_OUT �   PASSED_KENT1_DEATH_ROW �   PASSED_TEX1_FOUR_IRON �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PLAYER_CHAR    PLAYER_ACTOR    DEFAULT_WAIT_TIME    ONMISSION 9  CUT_SCENE_TIME |   CURRENT_TIME_IN_MS �  ARENA_DOOR_1    ARENA_DOOR_2    FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   FILM_STUDIO_BACK_GATE_OPEN   PRINT_WORKS_ASSET �  CAR_SHOWROOM_ASSET �  FILM_STUDIO_ASSET �  ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   FLAG   SRC �  {$CLEO .s}
0000:
thread 'RadioS'


{$INCLUDE ../Common/CleoConstants.txt}
int start_date
int end_date
int radio
int current_date

:PickupStart
wait 0
0AB4: current_date = var CDATE
// Wait until we are in the correct date range before creating pickup
if and
    current_date >= start_date
    current_date < end_date
else_jump @PickupStart
stream_custom_script "Radio/OneRadio.s" radio
0ADF: add_dynamic_GXT_entry "FEA_FM0" text "1800 static"
0ADF: add_dynamic_GXT_entry "FEA_FM1" text "KKHV 1940s"
0ADF: add_dynamic_GXT_entry "FEA_FM2" text "KKHV 1950s"
0ADF: add_dynamic_GXT_entry "FEA_FM3" text "KKHV 1960s"
0ADF: add_dynamic_GXT_entry "FEA_FM4" text "107.9 HVR 1970s"
0ADF: add_dynamic_GXT_entry "FEA_FM5" text "107.9 HVR 1980s"
0ADF: add_dynamic_GXT_entry "FEA_FM6" text "107.9 HVR 1990s"
0ADF: add_dynamic_GXT_entry "FEA_FM7" text "Rewind FM 2000s"
0ADF: add_dynamic_GXT_entry "FEA_FM8" text "Rewind FM Future"

:PickupCheck
wait 0
0AB4: current_date = var CDATE
// Destroy pickup when we're outside the date range 
if or
    current_date < start_date
    current_date >= end_date
else_jump @PickupCheck
0459: terminate_all_scripts_with_this_name 'onerad'
0ADF: add_dynamic_GXT_entry "FEA_FM0" text "1800 static"
0ADF: add_dynamic_GXT_entry "FEA_FM1" text "KKHV 1940s"
0ADF: add_dynamic_GXT_entry "FEA_FM2" text "KKHV 1950s"
0ADF: add_dynamic_GXT_entry "FEA_FM3" text "KKHV 1960s"
0ADF: add_dynamic_GXT_entry "FEA_FM4" text "107.9 HVR 1970s"
0ADF: add_dynamic_GXT_entry "FEA_FM5" text "107.9 HVR 1980s"
0ADF: add_dynamic_GXT_entry "FEA_FM6" text "107.9 HVR 1990s"
0ADF: add_dynamic_GXT_entry "FEA_FM7" text "Rewind FM 2000s"
0ADF: add_dynamic_GXT_entry "FEA_FM8" text "Rewind FM Future"
jump @PickupStart




U  __SBFTR 