  �K{i 1���U � ���U � ���U � ���U � ���U � ���U � ���U � �f�U � �a�U � �&�U � �!�U � ��U � ���U � �֎U � �юU � �U � ���U � ���U � �T�U �O�U � �M�U � ��U � �ޝU � �ٝU � ���U K���U � ���U d���U � �I ���I ���I ��I s���I s���I s��I � ���I � ���I � ��I � ���I � ���I � ���I � ���I � ���I � �3lJ � �.lJ  �)lJ  ��kJ � �~kJ � �|kJ  �VAR '   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_ASS1_RUB_OUT �   PASSED_KENT1_DEATH_ROW �   PASSED_TEX1_FOUR_IRON �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PLAYER_CHAR    PLAYER_ACTOR    DEFAULT_WAIT_TIME    ONMISSION 9  CUT_SCENE_TIME |   CURRENT_TIME_IN_MS �  ARENA_DOOR_1    ARENA_DOOR_2    FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   FILM_STUDIO_BACK_GATE_OPEN   PRINT_WORKS_ASSET �  CAR_SHOWROOM_ASSET �  FILM_STUDIO_ASSET �  ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   FLAG   SRC `  {$CLEO .cs}

//Here is the memory addresses for most of the HUD colors and in order of RGB values...
//The below script will change almost all HUD elements
wait 0 

05DF: write_memory 6912843 size 1 value 49 virtual_protect 1 //moneyfix

05DF: write_memory 5604015 size 1 value 255 virtual_protect 1   //Money R
05DF: write_memory 5604010 size 1 value 255 virtual_protect 1   //Money G
05DF: write_memory 5604005 size 1 value 255 virtual_protect 1   //Money B

05DF: write_memory 5606313 size 1 value 255 virtual_protect 1   //health R 
05DF: write_memory 5606308 size 1 value 255 virtual_protect 1   //health G
05DF: write_memory 5606303 size 1 value 255 virtual_protect 1   //health B

05DF: write_memory 5606542 size 1 value 255 virtual_protect 1   //health icon R
05DF: write_memory 5606502 size 1 value 255 virtual_protect 1   //health icon G
05DF: write_memory 5606497 size 1 value 255 virtual_protect 1   //health icon B

05DF: write_memory 5606950 size 1 value 255 virtual_protect 1   //armor R
05DF: write_memory 5606945 size 1 value 255 virtual_protect 1   //armor G
05DF: write_memory 5606940 size 1 value 255 virtual_protect 1   //armor B

05DF: write_memory 5607166 size 1 value 255 virtual_protect 1   //armor icon R
05DF: write_memory 5607126 size 1 value 255 virtual_protect 1   //armor icon G
05DF: write_memory 5607121 size 1 value 255 virtual_protect 1   //armor icon B

05DF: write_memory 5605570 size 1 value 255 virtual_protect 1   //ammo color R
05DF: write_memory 5605565 size 1 value 255 virtual_protect 1   //ammo color G
05DF: write_memory 5605560 size 1 value 255 virtual_protect 1   //ammo color B

{05DF: write_memory 5607626 size 1 value 255 virtual_protect 1   //wanted active R
05DF: write_memory 5607621 size 1 value 255 virtual_protect 1   //wanted active G
05DF: write_memory 5607616 size 1 value 255 virtual_protect 1   //wanted active B

05DF: write_memory 5607720 size 1 value 125 virtual_protect 1   //wanted suspended R
05DF: write_memory 5607715 size 1 value 125 virtual_protect 1   //wanted suspended G
05DF: write_memory 5607710 size 1 value 125 virtual_protect 1   //wanted suspended B

05DF: write_memory 5607792 size 1 value 0 virtual_protect 1     //wanted inactive R
05DF: write_memory 5607790 size 1 value 0 virtual_protect 1     //wanted inactive G
05DF: write_memory 5607785 size 1 value 0 virtual_protect 1     //wanted inactive B }
                                       
05DF: write_memory 5609812 size 1 value 8 virtual_protect 1      //zone R
05DF: write_memory 5609807 size 1 value 146 virtual_protect 1   //zone G
05DF: write_memory 5609805 size 1 value 208 virtual_protect 1   //zone B

05DF: write_memory 5610979 size 1 value 255 virtual_protect 1   //vehicle name R
05DF: write_memory 5610974 size 1 value 255 virtual_protect 1   //vehicle name G
05DF: write_memory 5610969 size 1 value 255 virtual_protect 1   //vehicle name B

05DF: write_memory 5611409 size 1 value 75 virtual_protect 1   //time R
05DF: write_memory 5611404 size 1 value 255 virtual_protect 1   //time G
05DF: write_memory 5611399 size 1 value 100 virtual_protect 1   //time B
05DF: write_memory 0x559EFC size 1 value 1 virtual_protect 1   //hud clock font   //0 rage //1 digital //2 bttf



05DF: write_memory 0x49F320 size 1 value 26 virtual_protect 1   //hud highlight R
05DF: write_memory 0x49F7DF size 1 value 26 virtual_protect 1   //hud highlight R
05DF: write_memory 0x49F9C8 size 1 value 26 virtual_protect 1   //hud highlight R

05DF: write_memory 0x49F31B size 1 value 115 virtual_protect 1   //hud highlight G
05DF: write_memory 0x49F7DA size 1 value 115 virtual_protect 1   //hud highlight G
05DF: write_memory 0x49F9C3 size 1 value 115 virtual_protect 1   //hud highlight G

05DF: write_memory 0x49F319 size 1 value 131 virtual_protect 1   //hud highlight B
05DF: write_memory 0x49F7D8 size 1 value 131 virtual_protect 1   //hud highlight B
05DF: write_memory 0x49F9C1 size 1 value 131 virtual_protect 1   //hud highlight B

05DF: write_memory 0x49F314 size 1 value 128 virtual_protect 1   //hud highlight A
05DF: write_memory 0x49F7D3 size 1 value 128 virtual_protect 1   //hud highlight A
05DF: write_memory 0x49F9BC size 1 value 128 virtual_protect 1   //hud highlight A
//05DF: write_memory 0x0049E818 size 1 value 1 virtual_protect 1  //shows pink menu text
//05DF: write_memory 0x0049E799 size 1 value 1 virtual_protect 1  //shows pink menu text
//05DF: write_memory 0x0049FD61 size 1 value 1 virtual_protect 1  //shows pink menu text
05DF: write_memory 0x0049E8EA size 1 value 255 virtual_protect 1 //main menu r
05DF: write_memory 0x0049E8E5 size 1 value 255 virtual_protect 1 //main menu g
05DF: write_memory 0x0049E8E0 size 1 value 255 virtual_protect 1 //main menu b



{05DF: write_memory 0x697C18 size 4 value 1000.0 virtual_protect 0   // Radardisc distance from bottom
05DF: write_memory 0x697B70 size 4 value 55.0 virtual_protect 0     // Weapon icon distance from right
05DF: write_memory 0x697B68 size 4 value 50.0 virtual_protect 0    // Weapon icon scale

05DF: write_memory 0x697B74 size 4 value 1000.0 virtual_protect 0   // Weapon ammo text vetical scale 
05DF: write_memory 0x697B78 size 4 value 75.0 virtual_protect 0   // Weapon ammo text distance from top 
05DF: write_memory 0x697B7C size 4 value 30.0 virtual_protect 0   // Weapon ammo text distance from right

05DF: write_memory 0x697B20 size 4 value 0.45 virtual_protect 0   // HUD Text horizontal scale
05DF: write_memory 0x697B50 size 4 value 1.20 virtual_protect 0   // HUD text vertical scale
05DF: write_memory 0x697B54 size 4 value 420.0 virtual_protect 0   // Money distance from top
05DF: write_memory 0x697B58 size 4 value 540.0 virtual_protect 0   // Money distance from right

05DF: write_memory 0x697BF0 size 4 value 03.0 virtual_protect 0   // Time distance from top
05DF: write_memory 0x697BF4 size 4 value 03.0 virtual_protect 0   // Time distance from right


05DF: write_memory 0x697B88 size 4 value 1000.0 virtual_protect 0   // Health and Armor distance from top
05DF: write_memory 0x697C1C size 4 value 102.0 virtual_protect 0// radar disc width
05DF: write_memory 0x68FD2C size 4 value 46.0 virtual_protect 0// radar x
05DF: write_memory 0x697C20 size 4 value 80.2 virtual_protect 0// radar disk height
05DF: write_memory 0x68FD34 size 4 value 113.0 virtual_protect 0//radar y     }

05DF: write_memory 0x4A6C33 size 1 value 255 virtual_protect 1 //Moving Loading Bar Color r
05DF: write_memory 0x4A6C2E size 1 value 0 virtual_protect 1 //Moving Loading Bar Color g
05DF: write_memory 0x4A6C29 size 1 value 0 virtual_protect 1 //Moving Loading Bar Color b

05DF: write_memory 0x4A6B80 size 1 value 255 virtual_protect 1 //Loading Bar Color r
05DF: write_memory 0x4A6B7E size 1 value 165 virtual_protect 1 //Loading Bar Color g
05DF: write_memory 0x4A6B7C size 1 value 0 virtual_protect 1 //Loading Bar Color b




05DC: end_custom_thread 

�  __SBFTR 