To use this branch you must first download and install the auto installer

Once complete you may download Leaf's experimental addons. these addons are usually in a concept stage and may or may not make it into the master branch but will always be available here.

Drag and drop the contents of the [Asset Pack](https://www.dropbox.com/scl/fo/wii1iojh0ymguuqmaeldv/AODjpADVUemnvH8uw5YYwAY?rlkey=dbh9n5p1uldr78u1tsz6okauq&st=1t34dr75&dl=1) into your game then replace the cleo folder in 0.2g lite with this one.

New Features in this branch
- New HUD:
- BTTF font is back.
- Top right hud is re organized and minimal hud is turned on for a cleaner look.
- Zones are replaced with street signs and relocated under the mini map on the left side of the screen.
- The Mini map now has an analog clock replacing the radar ring. and a night mode from 6pm to 6 am.
- Wanted stars now appear serially.

Plutonium Changes:
- Plutonium now gives you a physical box to carry 
- You can not enter vehicles, run, change weapons or attack while holding the plutonium box.
- To set it down or pick it up press the Action Key (default is TAB)
- To take a canister, first place the box on the ground. then press the Aim Key (default is right click)
- Once you have a canister in hand you can refuel the delorean. 
- It is not currently possible to place the box inside the delorean/truck. but will be in the future.

## You will Need Sanny Builder 3.8.0 installed. A newer version might not be compatible.
## Use the file `build_lite.bat` to compile all files needed.
## If the game crashes when trying to set the plutonium box down:
- Open file `mvl/debug.log` and go to its end.
- Look for the latest entry that says `LOADED - 'Plutonium' from archive 'mvl\vehicles\5_2_Plutonium.7z'` and copy the four numbers after the word `Vehicle`.
- Open file `modloader/bttf-hv-0.2g-lite/CLEO/Pickups/Plutonium/PlutoniumBox.txt`, change all incidences of `6003` with the copied numbers and save file.
- Recompile everything by using `build_lite.bat` or just open the edited TXT file in Sanny Builder and compile.
