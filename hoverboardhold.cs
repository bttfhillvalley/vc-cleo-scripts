    �      � �
      @@  K �
H  �M ���� �� �  7 �M (���  �    Gf�H�fM q���   ����U fU gU hU iU jU kU l  � fIf ����� �
      @@  K �
H  �M ����� �  7 �M i���  �    Gf�H�fM ����   ����U fU gU hU iU jU kU l  � gIf ����� �  7 �M ����  �    Gf�H�fM &���   <���U fU gU hU iU jU kU l  � hIf ����� �  7 �M Q���  �    Gf�H�fM ����   ����U fU gU hU iU jU kU l  � iIf ����� �  7 �M ����  �    Gf�H�fM ���   $���U fU gU hU iU jU kU l  � jIf ����� �  7 �M 9���  �    Gf�H�fM ����   ����U fU gU hU iU jU kU l  � kIf ����� �  7 �M ����  �    Gf�H�fM ����   ���U fU gU hU iU jU kU l  � lIf ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC !  {$CLEO .cs}   
{$USE RESTORATION} 
{$INCLUDE Common/CleoConstants.txt}
float x
float y
float z        
float angle 
int vehicle

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
    
   
//delete mattel car and give mattel weapon
    if and
            0AE2: vehicle = random_vehicle_near_point x y z in_radius 03.0 find_next 0 pass_wrecked 1
        044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
        timera > 500
then  
wait 500

if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4796 //mattel
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
//remove opcode requires restoration 
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 102 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)
else


//delete Question Mark car and give Question Mark weapon
    if and
            0AE2: vehicle = random_vehicle_near_point x y z in_radius 03.0 find_next 0 pass_wrecked 1
        044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 72 //H
        timera > 500
then  

if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4800 //Question Mark
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
//remove opcode requires restoration 
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 103 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)
else

//delete No Tech and give No Tech weapon
if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4801 //No Tech
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
//remove opcode requires restoration 
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 104 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)
else

//delete Pitbull and give Pitbull weapon
if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4802 //PitBull
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
//remove opcode requires restoration 
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 105 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)
else

//delete Rising Sun and give Rising Sun weapon
if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4803 //Rising Sun
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 106 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)
else


//delete 1955 Skateboard and give 1955 Skateboard weapon
if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4804 //1955 Skateboard
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 107 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)
else

//delete 1985 Skateboard and give 1985 Skateboard weapon
if and
                02D7:   player $PLAYER_CHAR current_weapon == 0
                Car.Model(vehicle) == 4806 //1955 Skateboard
            then
        wait 0
Car.Destroy(vehicle) //delete car
wait 0
Model.Load(102) //you have to load something or it'll cause random crashes (cant load MVL weapon models as we dont know their real id's)
038B: load_requested_models
while not  Model.Available(102)
wait 0
end
//Clear all hoverboards before adding new one (otherwise you sometimes get an invisible one and have to cycle weapons)
0555: remove_actor $PLAYER_ACTOR weapon 102
0555: remove_actor $PLAYER_ACTOR weapon 103
0555: remove_actor $PLAYER_ACTOR weapon 104
0555: remove_actor $PLAYER_ACTOR weapon 105
0555: remove_actor $PLAYER_ACTOR weapon 106
0555: remove_actor $PLAYER_ACTOR weapon 107
0555: remove_actor $PLAYER_ACTOR weapon 108
wait 0
01B1: give_player $PLAYER_CHAR weapon 108 ammo 1 // Load the weapon model before using this  
Model.Destroy(102)

end
end
end
end
end
end
end
end
end
end



S  __SBFTR 