@reg add "HKCU\Software\Microsoft\Windows\CurrentVersion\Explorer\MountPoints2\##LGEE1COMAFS01#E1-SW" /v _LabelFromReg /t REG_SZ /d "SW" /f
@net use s: /delete /y
@net use S: "\\LGEE1COMAFS01\E1-SW" /user:"lge\%username%"
exit