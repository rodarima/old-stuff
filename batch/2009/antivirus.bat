@echo off
color 70
title Utilidad para borrar virus del pendrive                                                           Rodrigo  2009
echo *****************************************************************************
echo ****************** UTILIDAD PARA BORRAR VIRUS DEL PENDRIVE ******************
echo *****************************************************************************
echo.
echo.
echo  Atencion!!! Esta utilidad borra los archivos de cualquier dispositivo
echo.
echo   - autorun.inf
echo   - autorun.exe
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo Pulse una tecla para seguir
echo *****************************************************************************
echo *****************************************************************************
pause > nul

cd..
cd..
cd..
cd..
attrib -a -s -h -r c:autorun.inf
attrib -a -s -h -r c:autorun.exe
del /q c:autorun.inf
del /q c:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir c:autorun.inf
attrib +s +h +r c:autorun.inf
echo.
echo [ ok ]




attrib -a -s -h -r d:autorun.inf
attrib -a -s -h -r d:autorun.exe
del /q d:autorun.inf
del /q d:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir d:autorun.inf
attrib +s +h +r d:autorun.inf
echo.
echo [ ok ]




attrib -a -s -h -r e:autorun.inf
attrib -a -s -h -r e:autorun.exe
del /q e:autorun.inf
del /q e:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir e:autorun.inf
attrib +s +h +r e:autorun.inf
echo.
echo [ ok ]





attrib -a -s -h -r g:autorun.inf
attrib -a -s -h -r g:autorun.exe
del /q g:autorun.inf
del /q g:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir g:autorun.inf
attrib +s +h +r g:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r h:autorun.inf
attrib -a -s -h -r h:autorun.exe
del /q h:autorun.inf
del /q h:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir h:autorun.inf
attrib +s +h +r h:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r i:autorun.inf
attrib -a -s -h -r i:autorun.exe
del /q i:autorun.inf
del /q i:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir i:autorun.inf
attrib +s +h +r i:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r j:autorun.inf
attrib -a -s -h -r j:autorun.exe
del /q j:autorun.inf
del /q j:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir j:autorun.inf
attrib +s +h +r j:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r k:autorun.inf
attrib -a -s -h -r k:autorun.exe
del /q k:autorun.inf
del /q k:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir k:autorun.inf
attrib +s +h +r k:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r l:autorun.inf
attrib -a -s -h -r l:autorun.exe
del /q l:autorun.inf
del /q l:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir l:autorun.inf
attrib +s +h +r l:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r n:autorun.inf
attrib -a -s -h -r n:autorun.exe
del /q n:autorun.inf
del /q n:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir n:autorun.inf
attrib +s +h +r n:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r o:autorun.inf
attrib -a -s -h -r o:autorun.exe
del /q o:autorun.inf
del /q o:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir o:autorun.inf
attrib +s +h +r o:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r a:autorun.inf
attrib -a -s -h -r a:autorun.exe
del /q a:autorun.inf
del /q a:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir a:autorun.inf
attrib +s +h +r a:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r b:autorun.inf
attrib -a -s -h -r b:autorun.exe
del /q b:autorun.inf
del /q b:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir b:autorun.inf
attrib +s +h +r b:autorun.inf
echo.
echo [ ok ]



attrib -a -s -h -r p:autorun.inf
attrib -a -s -h -r p:autorun.exe
del /q p:autorun.inf
del /q p:autorun.exe
echo.
echo Protegiendo pendrive...
echo.
mkdir p:autorun.inf
attrib +s +h +r p:autorun.inf
echo.
echo [ ok ]



pause > nul
cls
echo *****************************************************************************
echo ****************** UTILIDAD PARA BORRAR VIRUS DEL PENDRIVE ******************
echo *****************************************************************************
echo. 
echo  Ahora todos sus dispositivos han sido limpiados del archivo autorun.inf
echo  el cual es un archivo de windows que usan los virus para reproducirse
echo.
echo.
echo.
echo.
echo.
echo.
echo.
echo.

echo *****************************************************************************

pause
cls

echo.
echo  ATENCION !!!!!!!
echo.
echo  NO BORRE LA CARPETA AUTORUN.INF DE SU DISPOSITIVO, YA QUE
echo  LE PERMITE PROTEGERSE DE LOS VIRUS
echo.
echo  Ahora puede borrar los archivos sospechosos de su pendrive
echo  con total seguridad.
echo  Nota: Borre todos los archivos que no conozca y actualice
echo  su antivirus
echo.
echo  Gracias.
echo.
pause > nul