    �     � � fK �
H  �M N��� ��       �?       r  G��H��M ����   ����� �     u   I�U f�   ����� � gK �
H  �M ���� ��       �?       r  G��H��M ����   ����� �     u   I�U g�   ����� � hK �
H  �M ��� ��       �?       r  G��H��M E���   \���� �     u   I�U h�   ����� � iK �
H  �M t��� ��       �?       r  G��H��M ����   ����� �     u   I�U i�   ����� � jK �
H  �M ���� ��       �?       r  G��H��M 	���    ���� �     u   I�U j�   ����� � kK �
H  �M 8��� ��       �?       r  G��H��M k���   ����� �     u   I�U k�   ����� � lK �
H  �M ���� ��       �?       r  G��H��M ����   ����� �     u   I�U l�   ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC n  {$CLEO .cs} 
{$USE RESTORATION}  
{$INCLUDE Common/CleoConstants.txt}
int vehicle
float x
float y
float z        
float angle

{
//car models
4796 //mattel 
4800 //Question Mark
4801 //No Tech
4802 //PitBull
4803 //Rising Sun
4804 //1955 skateboard
4806 //1985 Skateboard

//Weapon Models (Props)
102 //mattel
103 //Question Mark
104 //No Tech
105 //PitBull
106 //Rising Sun
107 //1955 Skateboard
108 //1985 Skateboard   
}

0000:
while true
    wait 0
    00A0: store_actor $PLAYER_ACTOR position_to x y z 
    
      
    
    //delete mattel weapon and give mattel car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 102 //mattel weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4796)
        038B: load_requested_models
        while not  Model.Available(4796)
            wait 0
        end
        vehicle = Car.Create(4796, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4796)
        0555: remove_actor $PLAYER_ACTOR weapon 102 //mattel weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
       else 
       
           //delete question mark weapon and give question mark car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 103 //question mark weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4800)
        038B: load_requested_models
        while not  Model.Available(4800)
            wait 0
        end
        vehicle = Car.Create(4800, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4800)
        0555: remove_actor $PLAYER_ACTOR weapon 103 //question mark weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
       else 
       
           //delete no tech weapon and give no tech car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 104 //no tech weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4801)
        038B: load_requested_models
        while not  Model.Available(4801)
            wait 0
        end
        vehicle = Car.Create(4801, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4801)
        0555: remove_actor $PLAYER_ACTOR weapon 104 //no tech weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
       else 
       
    //delete PitBull weapon and give PitBull car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 105 //PitBull weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4802)
        038B: load_requested_models
        while not  Model.Available(4802)
            wait 0
        end
        vehicle = Car.Create(4802, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4802)
        0555: remove_actor $PLAYER_ACTOR weapon 105 //PitBull weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
       else 
              
       
    //delete rising sun weapon and give rising sun car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 106 //rising sun weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4803)
        038B: load_requested_models
        while not  Model.Available(4803)
            wait 0
        end
        vehicle = Car.Create(4803, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4803)
        0555: remove_actor $PLAYER_ACTOR weapon 106 //rising sun weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
       else 
              
       
    //delete 1955 skateboard weapon and give 1955 skateboard car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 107 //1955 skateboard weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4804)
        038B: load_requested_models
        while not  Model.Available(4804)
            wait 0
        end
        vehicle = Car.Create(4804, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4804)
        0555: remove_actor $PLAYER_ACTOR weapon 107 //1955 skateboard weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
       else 
              
    //delete 1985 Skateboard weapon and give 1985 Skateboard car 
    if and
    02D7:   player $PLAYER_CHAR current_weapon == 108 //1985 Skateboard weapon
    044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
    timera > 500
then  
wait 500
        04C4: create_coordinate x y z from_actor $PLAYER_ACTOR offset 0.0 1.0 0.0
        0172: angle = actor $PLAYER_ACTOR z_angle
        Model.Load(4806)
        038B: load_requested_models
        while not  Model.Available(4806)
            wait 0
        end
        vehicle = Car.Create(4806, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(4806)
        0555: remove_actor $PLAYER_ACTOR weapon 108 //1985 Skateboard weapon
        01B8: set_player $PLAYER_CHAR armed_weapon_to 0
              

end
end
end
end
end
end
end
end
f  __SBFTR 