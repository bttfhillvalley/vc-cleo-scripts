  �  �  �  �  �  �    �  	 
  � �
	 
    @@   K �
	  �M G��� ��  7   M  ���                	 
  t   �   G �H� M %���   <����  	 
    u   I  G����  7   M |���                	 
  t   �   G �H� M ����   �����  	 
    u   I  G����  7   M ����                	 
  t   �   G �H� M ���   4����  	 
    u   I  G����  7   M t���                	 
  t   �   G �H� M ����   �����  	 
    u   I  G����  7   M ����                	 
  t   �    �   G �H� M 
���   !����  	 
    )    u   I  G����  7   M G���                	 
  t   �    �   G �H� M p���   �����  	 
    )    u   I  ����VAR '   ARENA_DOOR_1    ARENA_DOOR_2    CAR_SHOWROOM_ASSET �  CURRENT_TIME_IN_MS �  CUT_SCENE_TIME |   DEFAULT_WAIT_TIME    FILM_STUDIO_ASSET �  FILM_STUDIO_BACK_GATE_CLOSED   FILM_STUDIO_BACK_GATE_OPEN   FILM_STUDIO_FRONT_GATE_CLOSED   FILM_STUDIO_FRONT_GATE_OPEN   ICE_CREAM_FACTORY_ASSET �  LANCE_VANCE �   ONMISSION 9  PASSED_ASS1_RUB_OUT �   PASSED_COK1_THE_CHASE �   PASSED_COK2_PHNOM_PENH_86 �   PASSED_COK3_THE_FASTEST_BOAT �   PASSED_COK4_SUPPLY_AND_DEMAND �   PASSED_COL1_TREACHEROUS_SWINE �   PASSED_COL2_MALL_SHOOTOUT �   PASSED_COL3_GUARDIAN_ANGELS �   PASSED_COL4_SIR_YES_SIR �   PASSED_COL5_ALL_HANDS_ON_DECK �   PASSED_HAT1_JUJU_SCRAMBLE   PASSED_HAT2_BOMBS_AWAY   PASSED_HAT3_DIRTY_LICKINS   PASSED_KENT1_DEATH_ROW �   PASSED_LAW1_THE_PARTY �   PASSED_LAW2_BACK_ALLEY_BRAWL �   PASSED_LAW3_JURY_FURY �   PASSED_LAW4_RIOT �   PASSED_ROCK1_LOVE_JUICE    PASSED_ROCK2_PSYCHO_KILLER !  PASSED_ROCK3_PUBLICITY_TOUR "  PASSED_TEX1_FOUR_IRON �   PLAYER_ACTOR    PLAYER_CHAR    PRINT_WORKS_ASSET �  FLAG   SRC �  {$CLEO .cs}   
{$INCLUDE Common/CleoConstants.txt}
int vehicle
int model1 = 4796 //mattel
int model2 = 4797 //mattel handlebars
int model3 = 4804  //1955 skateboard
int model4 = 4805 //1955 handlebars
int model5 = 4798 //generic hoverboard
int model6 = 4799 //generic handlebars   
int color1
int color2
float x
float y
float z        
float angle 
//look for a hoverboard with handlebars
0000:
while true
    wait 0
    00A0: store_actor $PLAYER_ACTOR position_to x y z   
    if and
        0AE2: vehicle = random_vehicle_near_point x y z in_radius 03.0 find_next 0 pass_wrecked 1
        044B:   actor $PLAYER_ACTOR on_foot
    is_key_pressed 9 //tab
        timera > 500
then  
wait 500
            if
                Car.Model(vehicle) == model2 //mattel with handlebars
            then
        wait 0
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 0.0
0174: angle = car vehicle z_angle
//destroy hoverboard without handlebars 
Car.Destroy(vehicle)
        //spawn new hoverboard with handlebars
        Model.Load(model1)
        038B: load_requested_models
        while not  Model.Available(model1)
            wait 0
        end
        vehicle = Car.Create(model1, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(model1)
else

if
                Car.Model(vehicle) == model1 //mattel with handlebars
            then
        wait 0
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 0.0
0174: angle = car vehicle z_angle
//destroy hoverboard without handlebars 
Car.Destroy(vehicle)
        //spawn new hoverboard with handlebars
        Model.Load(model2)
        038B: load_requested_models
        while not  Model.Available(model2)
            wait 0
        end
        vehicle = Car.Create(model2, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(model2)
        
        else  
            if
                Car.Model(vehicle) == model4 //1955 handlebars
            then
        wait 0
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 0.0
0174: angle = car vehicle z_angle
//destroy hoverboard without handlebars 
Car.Destroy(vehicle)
        //spawn new hoverboard with handlebars
        Model.Load(model3)
        038B: load_requested_models
        while not  Model.Available(model3)
            wait 0
        end
        vehicle = Car.Create(model3, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(model3)
else

if
                Car.Model(vehicle) == model3 //1955 skateboard
            then
        wait 0
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 0.0
0174: angle = car vehicle z_angle
//destroy hoverboard without handlebars 
Car.Destroy(vehicle)
        //spawn new hoverboard with handlebars
        Model.Load(model4)
        038B: load_requested_models
        while not  Model.Available(model4)
            wait 0
        end
        vehicle = Car.Create(model4, x, y, z)    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(model4)
        
        else
            if
                Car.Model(vehicle) == model6 //generic
            then
        wait 0
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 0.0
0174: angle = car vehicle z_angle
03F3: get_car vehicle color color1 color2
//destroy hoverboard without handlebars 
Car.Destroy(vehicle)
        //spawn new hoverboard with handlebars
        Model.Load(model5)
        038B: load_requested_models
        while not  Model.Available(model5)
            wait 0
        end
        vehicle = Car.Create(model5, x, y, z)   
        0229: set_car vehicle color_to color1 color2 
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(model5)
else

if
                Car.Model(vehicle) == model5 //generic handlebars
            then
        wait 0
0407: create_coordinate x y z from_car vehicle offset 0.0 0.0 0.0
0174: angle = car vehicle z_angle
03F3: get_car vehicle color color1 color2
//destroy hoverboard without handlebars 
Car.Destroy(vehicle)
        //spawn new hoverboard with handlebars
        Model.Load(model6)
        038B: load_requested_models
        while not  Model.Available(model6)
            wait 0
        end
        vehicle = Car.Create(model6, x, y, z)
        0229: set_car vehicle color_to color1 color2    
        0175: set_car vehicle z_angle_to angle
        Model.Destroy(model6)
end
end
end
end
end
end
end
end �  __SBFTR 