  �SPDMTR   
�  V� M ���� ����� �� M ���� ����� �  ��  ��  ��  ��  ��  ��  ��  �M n��� ����� �  ��  ��  �M D��� �����  A M %����    ����   �   � A �  �  1�   �?M ����  �  1� ��BM ����  ���=�    �����  9  M �����           �̒A�  !    \DM i���    \D�   �     d  db     d�     
  
b     
�

 �
 �
e � 9 
 9   9   M �����  A M ����     �2D ����      >D
  
� 	   	   �B�����	 	   �C   A   A� � � �  
  � 	  �����	 	   �C   B  pB� � � �   	   4B�����	 	   �C   B  pB� � � �  �  A M ���� 	   4B�����	 	   �C   B  pB� � � �    � 	  �     M ]���Z   �����	 	   �C   B  pB� � � �  Z    	   4B�����	 	   �C   B  pB� � � �  �  A M ����Z    	   4B�����	 	   �C   B  pB� � � �   �����R�� 	 ��� 
 ���  � 
 
 �    
   TDi  
     �Ci   i  
 i   ��          � �
  VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC P  {$CLEO .cs}
{$INCLUDE Common/CleoConstants.txt}
0000:
thread 'SPDMTR'
int vehicle
float vehicle_speed
float virtual_speed
int handbrake
int tens
int ones
int decimal
int texture_offset
float x_offset
float x
int hud_var
int travel_var
int cutscene_var


while true
    wait 10
    if
        not Player.Defined($PLAYER_CHAR)
    then
        continue
    end
    if or
        80E0:   not player $PLAYER_CHAR driving
        is_camera_in_widescreen_mode
    then
        continue
    end
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
        continue
    end
        if or
00DD:   actor $player_actor driving_vehicle_type 4804  //1955 skateboard
00DD:   actor $player_actor driving_vehicle_type 4805 //1955 handlebars
00DD:   actor $player_actor driving_vehicle_type 4806 //1985 skateboard
    then
        continue
    end
    if
        Player.InRemoteMode($PLAYER_CHAR)
    then
        vehicle = Player.RC_car($PLAYER_CHAR)
    else
        03C1: vehicle = player $PLAYER_CHAR car
    end

    02E3: vehicle_speed = car vehicle speed

    //check if the car is in remote mode
    if and
        Player.InRemoteMode($PLAYER_CHAR)
        00E1:   player 0 pressed_button 16 //gas/forward
        00E1:   player 0 pressed_button 14 //brake/reverse
        vehicle_speed < 1.0 //when the real car's speed is almost 0
    then
        handbrake = 1 //remember that the car is stopped
        if
            //max virtual speed limit chosen at random
            virtual_speed < 35.15 // 64.5mph
        then
            //increase the virtual speed
            virtual_speed += 0.1
        end
        vehicle_speed = virtual_speed
    else
        if
            handbrake == 1 //car is stopped
        then
            //release the stop and launch the car
            04BA: set_car vehicle speed_instantly virtual_speed
            handbrake = 0 // reset the stop so we only once set the speed from the burnout
            virtual_speed = 0
        end
    end

    // Parse speed into separate digits for rendering
    vehicle_speed *= 18.35
    if
        vehicle_speed > 880.0
    then
        vehicle_speed = 880.0
    end
    008C: decimal = float_to_integer vehicle_speed
    tens = decimal
    tens /= 100
    tens *= 100
    decimal -= tens
    tens /= 100

    ones = decimal
    ones /= 10
    ones *= 10
    decimal -= ones
    ones /= 10

    0AB4: hud_var = var HUD_DISP
    0AB4: travel_var = var TRAVEL
    0AB4: cutscene_var = var CUTSCENE
    if and
        hud_var == 1
        travel_var == 0
        cutscene_var == 0
    then
        if
            Player.InRemoteMode($PLAYER_CHAR)
        then
            texture_offset = 17
            x_offset = 715.0
        else
            texture_offset = 5
            x_offset = 760.0
        end

        texture_offset += 10
        // Dot
        x = x_offset
        x += 65.0
        05F5: call_scm_func @DrawTexture params_count 9 texture_offset x 470.0 10.0 10.0 255 255 255 255

        // Background
        texture_offset += 1
        x = x_offset
        05F5: call_scm_func @DrawTexture params_count 9 texture_offset x 440.0 40.0 60.0 255 255 255 255
        x += 45.0
        05F5: call_scm_func @DrawTexture params_count 9 texture_offset x 440.0 40.0 60.0 255 255 255 255
        if
            Player.InRemoteMode($PLAYER_CHAR)
        then
            x += 45.0
            05F5: call_scm_func @DrawTexture params_count 9 texture_offset x 440.0 40.0 60.0 255 255 255 255
        end

        // Reset offset
        texture_offset -= 11
        x = x_offset

        // tens digit
        if
            tens > 0
        then
            tens += texture_offset
            05F5: call_scm_func @DrawTexture params_count 9 tens x 440.0 40.0 60.0 255 255 255 255
        end

        // ones digit
        ones += texture_offset
        x += 45.0
        05F5: call_scm_func @DrawTexture params_count 9 ones x 440.0 40.0 60.0 255 255 255 255

        // decimal digit
        if
            Player.InRemoteMode($PLAYER_CHAR)
        then
            decimal += texture_offset
            x += 45.0
            05F5: call_scm_func @DrawTexture params_count 9 decimal x 440.0 40.0 60.0 255 255 255 255
        end
    end
end

{$INCLUDE Common/DrawTexture.txt}
�  __SBFTR 