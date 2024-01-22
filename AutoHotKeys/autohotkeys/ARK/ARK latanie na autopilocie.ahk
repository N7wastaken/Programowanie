#Persistent
Toggle := false

^Numpad1:: ; Ctrl+NumPad1 do włączania/wyłączania trzymania klawisza W
    Toggle := !Toggle
    
    if (Toggle)
    {
        Send, {w down}{Shift down}
    }
    else
    {
        Send, {Shift up}{w up}
    }
return
