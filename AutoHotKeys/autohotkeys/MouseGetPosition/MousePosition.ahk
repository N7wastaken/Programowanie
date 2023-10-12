#Persistent

CoordMode, Mouse, Screen
OutputFile := "Clicks.txt" ; Nazwa pliku

^1::
    MouseGetPos, MouseX, MouseY
    FileAppend, % MouseX "x" MouseY "`n", %OutputFile%
    if !FileExist(OutputFile)
    {
        Run, notepad.exe %OutputFile%
        WinWaitActive, ahk_exe notepad.exe
        Send, Clicks`n
    }
return
