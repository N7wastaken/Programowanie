#Persistent

CoordMode, Mouse, Screen
OutputFile := "Clicks.txt" ; Nazwa pliku

^1:: ; Kombinacja klawiszy Ctrl+1 do klikania i zapisywania koordynatów
    MouseGetPos, MouseX, MouseY
    komenda := "MouseClick, Left, " . MouseX . ", " . MouseY
    Run, cmd.exe /c echo %komenda% >> %OutputFile%
    if !FileExist(OutputFile)
    {
        Run, notepad.exe %OutputFile%
        WinWaitActive, ahk_exe notepad.exe
        Send, Clicks`n
    }
return
