Prepare for simulation
1.	Положить .exe в папку Х1
2.	Чтобы начать, нужно открыть существующий проект (Open project) (проект связанный только с GUI) или начать новый (New project), сохранить файл самого проекта в любой папке, не обязательно связаной с Х1. Может быть (Х1 или Хn).
3.	Вначале загрузить файл DEM.asc из X1 и отобразить в отдельной вкладке. 
4.	Открыть вкладку Boundary conditions, ввести параметры (обозначить на карте с DEM), сохранить и записать в папку Х1 как 2 файла.

  4.1.	  Файл 1: boundary conditions c расширением .bci, see example in the folder named "bci.bci". Should be at least 2 lines. Each line in the file looks like:
//// bci file//////
P           651279.331  4948612.447	QVAR		inf
text        float         float          text            text

  4.2.	  Файл 2: flow hydrograph с расширением .bdy, see example in the folder named "bdy.bdy". This is a time series file which contains first three lines (desctiprive lines), 
                  all other lines are: value and time. Should be possible to copy-paste the data from excel file to the GUI, as well as insert it manually. 
                  The length of the file is defined by the user.
//// bdy file//////   
Line 1: Comment line, ignored by LISFLOOD-FP.
Line 2: Boundary identifier (this should be consistent with notation supplied in the .bci file "inf").
Line 3: Number of time points at which boundary information is given followed by a keyword for the time units used (either
‘days’, ‘hours’ or ‘seconds’).
Line 4: Value1 Time1
Line 5: Value2 Time2
etc…. … …
Line i: Valuei Timei

  4.3.    File 3. Parameters for par file. first column - parameter name, second column - value/name of file. See example in folder "Param_25_weir.par"
//// parameter file//////
# breach test - first commented out line is compulsory
DEMfile         filename         
resroot         name  
dirroot         name   
sim_time        float             
initial_tstep   float            
massint         float           
saveint         float           
fpfric          float
bcifile         filename  
bdyfile         filename  
adaptoff        yes/no 
sgc_enable      yes/no 
drycheckon      yes/no 
elevoff         yes/no 
max_Froude      float    

5.	Открыть вкладку Parameters, ввести параметры (see above) и сохранить. Если одного из required* нет, вывести ошибку.
6.	Eсли ошибок нет, данные записываются в файлы с соответстсвующими расширениями. 
7.	Если нет ошибок и данныt записаны в соответствующии файлы – compute. (запускается .exe)
8. Утилита запукается командой lisflood_double.exe -v Param_25_weir.par

*required
DEMfile -  filename.asc
Boundary conditions filename.bci
** при включении определенных пареметров во вкладке Parameters, количество required увеличивается.  
