  �BARNDR      �C  �
� -    -�  M �����@3S��L�C�IA w 
�A�A=J�!��C�[A w  �B{4�!��C�[A w    ��C=J�!��C�[A w  �D=J�!��C�[A w  �E=J�!��C�[A w  �F=J�!��C�[A w  �G=J�!��C�[A w  �H=J�!��C�[A w  �I=J�!��C�[A w  �J=J�!��C�[A w  �K=J�!��C�[A w  �L=J�!��C�[A w  �M=J�!��C�[A w  �OhE�Έ�C�KA w   �B  �
� -�   -   M ����      ����VAR '   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_ASS1_RUB_OUT �   PASSED_KENT1_DEATH_ROW �   PASSED_TEX1_FOUR_IRON �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PLAYER_CHAR    PLAYER_ACTOR    DEFAULT_WAIT_TIME    ONMISSION 9  CUT_SCENE_TIME |   CURRENT_TIME_IN_MS �  ARENA_DOOR_1    ARENA_DOOR_2    FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   FILM_STUDIO_BACK_GATE_OPEN   PRINT_WORKS_ASSET �  CAR_SHOWROOM_ASSET �  FILM_STUDIO_ASSET �  ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   FLAG   SRC   {$CLEO .s}
0000:
thread 'barndr'
int start_date
int end_date
int current_date
int barndoor
int mailbox
int scarecrow
float angle = 260.0

:PickupStart
wait 0
0AB4: current_date = var CDATE
// Wait until we are in the correct date range before creating pickup
if and
    current_date >= start_date
    current_date < end_date
else_jump @PickupStart
mailbox = Object.Init(6976,  -517.3, 294.6, 12.57)
Object.Angle(mailbox) = 9.99

barndoor = Object.Init(6977,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6978,  -536.82, 275.876, 13.73)
Object.Angle(barndoor) = -10.0

barndoor = Object.Init (6979, -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6980,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6981,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6982,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6983,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6984,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6985,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6986,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6987,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6988,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

barndoor = Object.Init(6989,  -537.16, 273.876, 13.73)
Object.Angle(barndoor) = angle

scarecrow = Object.Init(6991,  -545.0845, 313.0688, 12.7444)
Object.Angle(scarecrow) = 90.0



:PickupCheck
wait 0
0AB4: current_date = var CDATE
// Destroy pickup when we're outside the date range 
if or
    current_date < start_date
    current_date >= end_date
else_jump @PickupCheck
wait 0
0108: destroy_object barndoor
0108: destroy_object mailbox
0108: destroy_object scarecrow

jump @PickupStart





I  __SBFTR 