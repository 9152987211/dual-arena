Module Module1
    Const bspeed As Integer = 10
    Const minionsped As Integer = 100
    Sub Main()

        Console.Title = "Dual Arena"
        Console.Clear()
        OpeningScreen()

    End Sub
    Sub OpeningScreen()

        Console.Clear()
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("                                                                By Adam Osborne")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("                      8888888b.  888     888        d8888 888   ")
        Console.WriteLine("                      888    88b 888     888       d88888 888")
        Console.WriteLine("                      888    888 888     888     d88P 888 888")
        Console.WriteLine("                      888    888 888     888     d88P 888 888 ")
        Console.WriteLine("                      888    888 888     888    d88P  888 888")
        Console.WriteLine("                      888    888 888     888   d88P   888 888  ")
        Console.WriteLine("                      888  .d88P Y88b. .d88P  d8888888888 888")
        Console.WriteLine("                      8888888P'   'Y88888P'  d88P     888 88888888 ")
        Console.WriteLine("")
        Console.WriteLine("                   d8888 8888888b.  8888888888 888b    888        d8888 ")
        Console.WriteLine("                   d88888 888   Y88b 888        8888b   888       d88888 ")
        Console.WriteLine("                  d88P888 888    888 888        88888b  888      d88P888")
        Console.WriteLine("                 d88P 888 888   d88P 8888888    888Y88b 888     d88P 888 ")
        Console.WriteLine("                d88P  888 8888888P'  888        888 Y88b888    d88P  888 ")
        Console.WriteLine("               d88P   888 888 T88b   888        888  Y88888   d88P   888 ")
        Console.WriteLine("              d8888888888 888  T88b  888        888   Y8888  d8888888888 ")
        Console.WriteLine("             d88P     888 888   T88b 8888888888 888    Y888 d88P     888")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                                 Press ENTER to START.")


        Console.ReadLine()

        StartScreen()

    End Sub
    Sub StartScreen()

        Dim gm As Char
        Dim skey As String

        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                              Choose a Game Type")
        Console.WriteLine("")
        Console.WriteLine("                   [S] SinglePlayer.          [M] Multiplayer.")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("                     +--^----------, --------, -----, --------^ -, ")
        Console.WriteLine("                     | |||||||||   `--------'     |          O")
        Console.WriteLine("                     `+---------------------------^----------|")
        Console.WriteLine("                       `\_,---------,---------,--------------'")
        Console.WriteLine("                         / XXXXXX /'|       /'")
        Console.WriteLine("                        / XXXXXX /  `\    /'")
        Console.WriteLine("                       / XXXXXX /`-------'")
        Console.WriteLine("                      / XXXXXX /")
        Console.WriteLine("                     / XXXXXX /")
        Console.WriteLine("                    (________(")
        Console.WriteLine("                     `------' ")

        Do Until gm = "s" Or gm = "m"
            If Console.KeyAvailable = True Then
                skey = Console.ReadKey().Key
            End If

            If skey = ConsoleKey.S Then
                gm = "s"
            ElseIf skey = ConsoleKey.M Then
                gm = "m"
            End If

        Loop

        Select Case gm
            Case "s"
                SinglePlayer()
            Case "m"
                GunSelection()
        End Select

    End Sub
    Sub GunSelection()

        Dim sKey1 As String
        Dim sKey2 As String
        Dim p1Gun As Char
        Dim p2Gun As Char
        Dim temp As Decimal

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("                                  GUN SELECTION")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("    PLAYER 1 ")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Choose Your Gun.")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("    [A] ┌")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("    Bullet Speed: 1    Health: Three Hearts")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("    [B] ╔")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("    Bullet Speed: 4    Health: One Heart")

        Do Until p1Gun = "A" Or p1Gun = "B"
            If Console.KeyAvailable = True Then
                sKey1 = Console.ReadKey().Key
            End If

            If sKey1 = ConsoleKey.A Then
                p1Gun = "A"
            ElseIf sKey1 = ConsoleKey.B Then
                p1Gun = "B"
            End If

        Loop

        temp = Timer()
        Do Until Timer() >= temp + 0.01
        Loop

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("                                  GUN SELECTION")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.Write("    PLAYER 2 ")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Choose Your Gun.")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("    [A] ┌")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("    Bullet Speed: 1    Damage: One Heart")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.Write("    [B] ╔")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("    Bullet Speed: 4    Damage: Half a Heart")

        Do Until p2Gun = "A" Or p2Gun = "B"
            If Console.KeyAvailable = True Then
                sKey2 = Console.ReadKey().Key
            End If

            If sKey2 = ConsoleKey.A Then
                p2Gun = "A"
            ElseIf sKey2 = ConsoleKey.B Then
                p2Gun = "B"
            End If

        Loop


        Multiplayer(p1Gun, p2Gun)

    End Sub
    Sub Multiplayer(ByRef p1Gun As Char, ByRef p2gun As Char)

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White

        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("                                   MULTIPLAYER")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("         In This Mode You Will 1V1 Another Player Using The Same Keyboard.")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.Write("PLAYER 1 ")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Will Use 'WASD' to Move and 'R' to Shoot.")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.Write("PLAYER 2 ")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Will Use The ArrowKeys to move and 'L' to Shoot.")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                     Press ENTER When you Are Ready to Begin.")
        Console.ReadLine()
        MPstart(p1Gun, p2gun)

    End Sub
    Sub MPstart(ByRef p1Gun As Char, ByRef p2Gun As Char)

        Dim p1hp As String
        Dim p2hp As String
        Dim win As Integer = 0 '1 = player 1 won,    2= Player 2 won,    0 = no one has currently won.
        Dim p1xpos As Integer = 10
        Dim p1ypos As Integer = Console.WindowHeight / 2
        Dim p2xpos As Integer = 70
        Dim p2ypos As Integer = Console.WindowHeight / 2
        Dim kpressed As Boolean = False
        Dim sKey As String
        Dim tempXp1 As Integer
        Dim tempYp1 As Integer
        Dim tempXp2 As Integer
        Dim tempYp2 As Integer
        Dim p1bulletfired As Boolean = False
        Dim p2bulletfired As Boolean = False
        Dim p1BulletCounter As Integer = 0
        Dim p2BullteCounter As Integer = 0
        Dim p1bullteX As Integer
        Dim p2bulletX As Integer
        Dim counter As Integer = 0
        Dim stopgamebreakingp1 As Boolean = False
        Dim stopgamebreakingp2 As Boolean = False
        Dim temp As Decimal
        Dim RoundTime As Integer

        If p1Gun = "A" Then
            p1hp = "♥ ♥ ♥"
        ElseIf p1Gun = "B" Then
            p1hp = "♥"
        End If

        If p2Gun = "A" Then
            p2hp = "♥ ♥ ♥"
        ElseIf p2Gun = "B" Then
            p2hp = "♥"
        End If

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine("")
        Console.Write("        PLAYER 1")
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("                                            PLAYER 2")
        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(8, 2)
        Console.WriteLine(p1hp, 8, 2)
        Console.SetCursorPosition(60, 2)
        Console.WriteLine(p2hp, 60, 2)

        MPdrawbackground()

        temp = Timer()

        Do Until win <> 0

            counter = counter + 1

            MPdrawP1(p1xpos, p1ypos, p1Gun)
            MPdrawP2(p2xpos, p2ypos, p2Gun)
            keypressed(kpressed, sKey)

            RoundTime = Timer() - temp

            If counter Mod 100 = 0 Then
                Console.ForegroundColor = ConsoleColor.White
                Console.CursorVisible = False
                Console.SetCursorPosition(39, 1)
                Console.WriteLine("    ", 39, 1)
                Console.SetCursorPosition(39, 1)
                Console.WriteLine(RoundTime, 39, 1)

            End If

            If kpressed = True Then
                If sKey = ConsoleKey.W And p1ypos > 4 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p1xpos, p1ypos)
                    Console.Write("   ", p1xpos, p1ypos)
                    p1ypos = p1ypos - 1
                ElseIf sKey = ConsoleKey.A And p1xpos > 2 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p1xpos, p1ypos)
                    Console.Write("   ", p1xpos, p1ypos)
                    p1xpos = p1xpos - 1
                ElseIf sKey = ConsoleKey.S And p1ypos < 22 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p1xpos, p1ypos)
                    Console.Write("   ", p1xpos, p1ypos)
                    p1ypos = p1ypos + 1
                ElseIf sKey = ConsoleKey.D And p1xpos < 17 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p1xpos, p1ypos)
                    Console.Write("   ", p1xpos, p1ypos)
                    p1xpos = p1xpos + 1



                ElseIf sKey = ConsoleKey.UpArrow And p2ypos > 4 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p2xpos, p2ypos)
                    Console.Write("   ", p2xpos, p2ypos)
                    p2ypos = p2ypos - 1
                ElseIf sKey = ConsoleKey.LeftArrow And p2xpos > 61 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p2xpos, p2ypos)
                    Console.Write("   ", p2xpos, p2ypos)
                    p2xpos = p2xpos - 1
                ElseIf sKey = ConsoleKey.DownArrow And p2ypos < 22 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p2xpos, p2ypos)
                    Console.Write("   ", p2xpos, p2ypos)
                    p2ypos = p2ypos + 1
                ElseIf sKey = ConsoleKey.RightArrow And p2xpos < 76 Then
                    Console.CursorVisible = False
                    Console.SetCursorPosition(p2xpos, p2ypos)
                    Console.Write("   ", p2xpos, p2ypos)
                    p2xpos = p2xpos + 1



                ElseIf sKey = ConsoleKey.R And p1bulletfired = False Then
                    p1bulletfired = True
                    tempXp1 = p1xpos
                    tempYp1 = p1ypos
                    stopgamebreakingp1 = True
                ElseIf sKey = ConsoleKey.L And p2bulletfired = False Then
                    p2bulletfired = True
                    tempXp2 = p2xpos
                    tempYp2 = p2ypos
                    stopgamebreakingp2 = True
                End If
            End If


            If counter Mod bspeed = 0 Then
                If p1bulletfired = True Then

                    If p1bullteX = 20 Or p1bullteX = 60 Then
                        Console.ForegroundColor = ConsoleColor.White
                        Console.SetCursorPosition(p1bullteX, tempYp1)
                        Console.Write("░", p1bullteX, tempYp1)
                    Else
                        Console.SetCursorPosition(p1bullteX, tempYp1)
                        Console.Write(" ", p1bullteX, tempYp1)
                    End If

                    p1BulletCounter = p1BulletCounter + 1
                    If p1Gun = "A" Then
                        p1bullteX = tempXp1 + p1BulletCounter
                    ElseIf p1Gun = "B" Then
                        p1bullteX = tempXp1 + (4 * p1BulletCounter)
                    End If

                    If p1bullteX = 78 Or p1bullteX = 79 Then
                        p1bulletfired = False
                        p1BulletCounter = 0
                    Else
                        P1Bullet(p1bullteX, tempYp1)
                    End If

                End If
            End If


            If counter Mod bspeed = 0 Then
                If p2bulletfired = True Then

                    If p2bulletX = 20 Or p2bulletX = 60 Then
                        Console.ForegroundColor = ConsoleColor.White
                        Console.SetCursorPosition(p2bulletX, tempYp2)
                        Console.Write("░", p2bulletX, tempYp2)
                    Else
                        Console.SetCursorPosition(p2bulletX, tempYp2)
                        Console.Write(" ", p2bulletX, tempYp2)
                    End If

                    p2BullteCounter = p2BullteCounter + 1

                    If p2Gun = "A" Then
                        p2bulletX = tempXp2 - p2BullteCounter
                    ElseIf p2Gun = "B" Then
                        p2bulletX = tempXp2 - (4 * p2BullteCounter)
                    End If

                    If p2bulletX = 2 Or p2bulletX = 1 Then
                            p2bulletfired = False
                            p2BullteCounter = 0
                        Else
                            P2Bullet(p2bulletX, tempYp2)
                        End If

                    End If
                End If

            If p1bullteX = p2xpos And tempYp1 = p2ypos And stopgamebreakingp1 = True Then
                p1bullteX = p1xpos
                Console.ForegroundColor = ConsoleColor.Red
                If p2hp = "♥ ♥ ♥ ♥" Then
                    stopgamebreakingp1 = False
                    Console.SetCursorPosition(60, 2)
                    Console.WriteLine("     ", 60, 2)
                    p2hp = "♥ ♥ ♥"
                ElseIf p2hp = "♥ ♥ ♥" Then
                    stopgamebreakingp1 = False
                    Console.SetCursorPosition(60, 2)
                    Console.WriteLine("     ", 60, 2)
                    p2hp = "♥ ♥"
                    Console.SetCursorPosition(60, 2)
                    Console.WriteLine(p2hp, 60, 2)
                ElseIf p2hp = "♥ ♥" Then
                    stopgamebreakingp1 = False
                    Console.SetCursorPosition(60, 2)
                    Console.WriteLine("     ", 60, 2)
                    p2hp = "♥"
                    Console.SetCursorPosition(60, 2)
                    Console.WriteLine(p2hp, 60, 2)
                ElseIf p2hp = "♥" Then
                    stopgamebreakingp1 = False
                    win = 1
                End If
            ElseIf p2bulletX = p1xpos And tempYp2 = p1ypos And stopgamebreakingp2 = True Then
                Console.ForegroundColor = ConsoleColor.Red
                p2bulletX = p2xpos
                If p1hp = "♥ ♥ ♥ ♥" Then
                    stopgamebreakingp2 = False
                    Console.SetCursorPosition(8, 2)
                    Console.WriteLine("     ", 8, 2)
                    p1hp = "♥ ♥ ♥"
                    Console.SetCursorPosition(8, 2)
                    Console.WriteLine(p1hp, 8, 2)
                ElseIf p1hp = "♥ ♥ ♥" Then
                    stopgamebreakingp2 = False
                    Console.SetCursorPosition(8, 2)
                    Console.WriteLine("     ", 8, 2)
                    p1hp = "♥ ♥"
                    Console.SetCursorPosition(8, 2)
                    Console.WriteLine(p1hp, 8, 2)
                ElseIf p1hp = "♥ ♥" Then
                    stopgamebreakingp2 = False
                    Console.SetCursorPosition(8, 2)
                    Console.WriteLine("     ", 8, 2)
                    p1hp = "♥"
                    Console.SetCursorPosition(8, 2)
                    Console.WriteLine(p1hp, 8, 2)
                ElseIf p1hp = "♥" Then
                    stopgamebreakingp2 = False
                    win = 2
                End If
            End If

        Loop

        mpWin(win)

    End Sub
    Sub MPdrawbackground()

        Console.ForegroundColor = ConsoleColor.White

        For i = 1 To 79
            Console.Write("█")
        Next
        Console.WriteLine("")

        Console.SetCursorPosition(1, 23)
        Console.Write("█")

        For i = 1 To 78
            Console.Write("█")
        Next

        For i = 4 To 22
            Console.SetCursorPosition(20, i)
            Console.Write("░", 20, i)
        Next

        For i = 4 To 22
            Console.SetCursorPosition(60, i)
            Console.Write("░", 60, i)
        Next

    End Sub
    Sub MPdrawP1(ByRef p1xpos As Integer, ByRef p1ypos As Integer, ByRef p1Gun As Char)

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.CursorVisible = False
        Console.SetCursorPosition(p1xpos, p1ypos)
        If p1Gun = "A" Then
            Console.Write("█┌", p1xpos, p1ypos)
        ElseIf p1Gun = "B" Then
            Console.Write("█╔", p1xpos, p1ypos)
        End If

    End Sub
    Sub MPdrawP2(ByRef p2xpos As Integer, ByRef p2ypos As Integer, ByRef p2Gun As Char)

        Console.ForegroundColor = ConsoleColor.Magenta
        Console.CursorVisible = False
        Console.SetCursorPosition(p2xpos, p2ypos)
        If p2Gun = "A" Then
            Console.Write("┐█", p2xpos, p2ypos)
        ElseIf p2Gun = "B" Then
            Console.Write("╗█", p2xpos, p2ypos)
        End If

    End Sub
    Sub keypressed(ByRef kpressed As Boolean, ByRef sKey As String)

        If Console.KeyAvailable = True Then
            kpressed = True
            sKey = Console.ReadKey().Key
        Else
            kpressed = False
        End If

    End Sub
    Sub P1Bullet(ByRef p1BullteX As Integer, ByRef tempYp1 As Integer)

        If p1BullteX < 0 Then
            p1BullteX = 0
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.CursorVisible = False
        Console.SetCursorPosition(p1BullteX, tempYp1)
        Console.Write("~", p1BullteX, tempYp1)

    End Sub
    Sub P2Bullet(ByRef p2BulletX As Integer, ByRef tempYp2 As Integer)

        If p2BulletX < 0 Then
            p2BulletX = 0
        End If

        Console.ForegroundColor = ConsoleColor.White
        Console.CursorVisible = False
        Console.SetCursorPosition(p2BulletX, tempYp2)
        Console.Write("~", p2BulletX, tempYp2)

    End Sub
    Sub mpWin(ByRef win As Integer)

        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("")
        Select Case win
            Case 1
                Console.ForegroundColor = ConsoleColor.Cyan
                Console.WriteLine("PLAYER 1 ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("WON!")
            Case 2
                Console.ForegroundColor = ConsoleColor.Magenta
                Console.WriteLine("PLAYER 2 ")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("WON!")
        End Select
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Press ENTER to Return to the Main Screen.")
        Console.ReadLine()
        Main()

    End Sub
    Sub SinglePlayer()

        Dim sKey As String

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("                                  SINGLEPLAYER")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                           Choose a Gamemode to Play.")
        Console.WriteLine("")
        Console.WriteLine("                    [S] Survival.            [F] Fight Mode")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("                 You Dont Have a Gun        Similar to Survival but")
        Console.WriteLine("                 and you have to Dodge      You have a gun to use to")
        Console.WriteLine("                 for a Certain Amount       fight back.")
        Console.WriteLine("                 of Time.")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.White

        Do Until sKey = "s" Or sKey = "f"
            If Console.KeyAvailable = True Then
                sKey = Console.ReadKey().Key
                If sKey = ConsoleKey.S Then
                    sKey = "s"
                ElseIf sKey = ConsoleKey.F Then
                    sKey = "f"
                End If
            End If
        Loop

        Select Case sKey
            Case "s"
                Survival()
            Case "f"
        End Select

    End Sub
    Sub Survival()

        Console.Clear()
        Console.WriteLine("")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("                                         SURVIVAL")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Green
        Console.WriteLine("")
        Console.WriteLine("                                   /| ________________")
        Console.WriteLine("                              O|===|* >________________>")
        Console.WriteLine("                                    \|")
        Console.WriteLine("")
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("                                   Press Enter To Start.")
        Console.ReadLine()

        Dim level As Integer = 1

        SurvivalStart(level)

    End Sub
    Sub SurvivalStart(ByRef level As Integer)

        Dim GameOver As Boolean = False

        Do Until GameOver = True Or level = 11

            Dim levelWon As Boolean = False
            Dim xpos As Integer = 10
            Dim ypos As Integer = 10
            Dim kpressed As Boolean = False
            Dim sKey As String
            Dim temp As Decimal
            Dim time As Integer
            Dim counter As Integer = 0
            Dim num As Integer
            Dim Mxpos(level) As Integer
            Dim Mypos(level) As Integer
            Dim bulletx(level) As Integer
            Dim bullety(level) As Integer
            Dim mnum As Integer
            Dim MinionBulletTiming(10) As Integer
            Dim tempmnum As Integer
            Const minionbulletspeed As Integer = 50
            Dim minionbulletfired(10) As Boolean

            For i = 1 To 10
                minionbulletfired(i) = False
            Next

            MinionBulletTiming(1) = 500
            MinionBulletTiming(2) = 600
            MinionBulletTiming(3) = 700
            MinionBulletTiming(4) = 800
            MinionBulletTiming(5) = 900
            MinionBulletTiming(6) = 1000
            MinionBulletTiming(7) = 1100
            MinionBulletTiming(8) = 1200
            MinionBulletTiming(9) = 1300
            MinionBulletTiming(10) = 1400

            Select Case level
                Case 1
                    Mxpos(1) = 60
                    Mypos(1) = 12
                Case 2
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10
                Case 3
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8
                Case 4
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6
                Case 5
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6

                    Mxpos(5) = 60
                    Mypos(5) = 14
                Case 6
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6

                    Mxpos(5) = 60
                    Mypos(5) = 14

                    Mxpos(6) = 60
                    Mypos(6) = 16
                Case 7
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6

                    Mxpos(5) = 60
                    Mypos(5) = 14

                    Mxpos(6) = 60
                    Mypos(6) = 16

                    Mxpos(7) = 60
                    Mypos(7) = 18
                Case 8
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6

                    Mxpos(5) = 60
                    Mypos(5) = 14

                    Mxpos(6) = 60
                    Mypos(6) = 16

                    Mxpos(7) = 60
                    Mypos(7) = 18

                    Mxpos(8) = 60
                    Mypos(8) = 20
                Case 9
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6

                    Mxpos(5) = 60
                    Mypos(5) = 14

                    Mxpos(6) = 60
                    Mypos(6) = 16

                    Mxpos(7) = 60
                    Mypos(7) = 18

                    Mxpos(8) = 60
                    Mypos(8) = 20

                    Mxpos(9) = 62
                    Mypos(9) = 20
                Case 10
                    Mxpos(1) = 60
                    Mypos(1) = 12

                    Mxpos(2) = 60
                    Mypos(2) = 10

                    Mxpos(3) = 60
                    Mypos(3) = 8

                    Mxpos(4) = 60
                    Mypos(4) = 6

                    Mxpos(5) = 60
                    Mypos(5) = 14

                    Mxpos(6) = 60
                    Mypos(6) = 16

                    Mxpos(7) = 60
                    Mypos(7) = 18

                    Mxpos(8) = 60
                    Mypos(8) = 20

                    Mxpos(9) = 62
                    Mypos(9) = 20

                    Mxpos(10) = 62
                    Mypos(10) = 18
            End Select



            Console.Clear()
            Console.CursorVisible = False
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.White
            Console.SetCursorPosition(1, 0)
            Console.WriteLine("Level: " & level & "                                                Survive For 30 Seconds.")
            DrawSPBorder()
            Console.SetCursorPosition(38, 0)
            Console.Write("▄▄▄▄▄▄", 38, 0)
            Console.SetCursorPosition(38, 2)
            Console.Write("██████", 38, 2)

            temp = Timer()

            Do Until GameOver = True Or levelWon = True

                DrawPlayer(xpos, ypos)
                keypressed(kpressed, sKey)


                counter = counter + 1

                If kpressed = True Then

                    If sKey = ConsoleKey.W And ypos > 4 Then
                        Console.SetCursorPosition(xpos, ypos)
                        Console.Write("  ", xpos, ypos)
                        ypos = ypos - 1
                    ElseIf sKey = ConsoleKey.A And xpos > 1 Then
                        Console.SetCursorPosition(xpos, ypos)
                        Console.Write("  ", xpos, ypos)
                        xpos = xpos - 1
                    ElseIf sKey = ConsoleKey.S And ypos < 22 Then
                        Console.SetCursorPosition(xpos, ypos)
                        Console.Write("  ", xpos, ypos)
                        ypos = ypos + 1
                    ElseIf sKey = ConsoleKey.D And xpos < 38 Then
                        Console.SetCursorPosition(xpos, ypos)
                        Console.Write("  ", xpos, ypos)
                        xpos = xpos + 1
                    End If

                End If

                For i = 1 To level
                    mnum = i
                    DrawMinion(Mxpos, Mypos, mnum)
                Next

                For i = 1 To level
                    If counter Mod MinionBulletTiming(i) = 0 And minionbulletfired(i) = False Then
                        minionbulletfired(i) = True
                        bulletx(i) = Mxpos(i)
                        bullety(i) = Mypos(i)
                        tempmnum = i
                        DrawMinionBullet(bulletx, bullety, tempmnum)
                    End If
                Next

                time = Timer() - temp

                If counter Mod 500 = 0 Then
                    Console.ForegroundColor = ConsoleColor.White
                    Console.SetCursorPosition(38, 1)
                    If time < 10 Then
                        Console.Write("▐ 0" & time & " ▌", 38, 1)
                    ElseIf time >= 10 Then
                        Console.Write("▐ " & time & " ▌", 38, 1)
                    End If
                End If

                If counter Mod minionbulletspeed = 0 Then
                    For i = 1 To level
                        tempmnum = i
                        If minionbulletfired(i) = True Then
                            If bulletx(tempmnum) = 40 Then
                                Console.ForegroundColor = ConsoleColor.White
                                Console.SetCursorPosition(bulletx(tempmnum), bullety(tempmnum))
                                Console.Write("░", bulletx(tempmnum), bullety(tempmnum))
                            Else
                                Console.SetCursorPosition(bulletx(tempmnum), bullety(tempmnum))
                                Console.Write(" ", bulletx(tempmnum), bullety(tempmnum))
                            End If
                            bulletx(i) = bulletx(i) - 1
                            DrawMinionBullet(bulletx, bullety, tempmnum)
                        End If

                        If bulletx(tempmnum) = xpos And bullety(tempmnum) = ypos Then
                            Console.SetCursorPosition(bulletx(tempmnum), bullety(tempmnum))
                            Console.Write(" ", bulletx(tempmnum), bullety(tempmnum))
                            GameOver = True
                        End If

                        If bulletx(tempmnum) < 2 Then
                            Console.SetCursorPosition(bulletx(tempmnum), bullety(tempmnum))
                            Console.Write(" ", bulletx(tempmnum), bullety(tempmnum))
                            minionbulletfired(tempmnum) = False
                        End If

                    Next
                End If


                If counter Mod minionsped = 0 Then
                    For i = 1 To level
                        Randomize()
                        num = CInt(Int((4 * Rnd()) + 1))

                        Console.SetCursorPosition(Mxpos(i), Mypos(i))
                        Console.Write("  ", Mxpos(i), Mypos(i))

                        If num = 1 And Mxpos(i) < 77 Then
                            Mxpos(i) = Mxpos(i) + 1
                        ElseIf num = 2 And Mypos(i) > 4 Then
                            Mypos(i) = Mypos(i) - 1
                        ElseIf num = 3 And Mxpos(i) > 41 Then
                            Mxpos(i) = Mxpos(i) - 1
                        ElseIf num = 4 And Mypos(i) < 22 Then
                            Mypos(i) = Mypos(i) + 1
                        End If
                    Next
                End If

                If time = 30 Then
                    levelWon = True
                End If

            Loop

            If GameOver = False Then
                Console.Clear()
                Console.SetCursorPosition(0, 0)
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.WriteLine("")
                Console.ForegroundColor = ConsoleColor.White
                Console.WriteLine("                              YOU COMPLETED LEVEL " & level)
                temp = Timer()

                Do Until Timer() >= temp + 2
                Loop

                level = level + 1
            End If
        Loop

        If GameOver = False Then
            Console.Clear()
            Console.SetCursorPosition(0, 0)
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Green
            Console.WriteLine("                                     CONGRATULATIONS!")
            Console.WriteLine("                                YOU COMPLETED ALL 10 LEVELS.")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("                            Press ENTER to Return to the Main Menu.")
            Console.ReadLine()
            Console.Clear()
            Main()
        ElseIf GameOver = True Then
            Console.Clear()
            Console.SetCursorPosition(0, 0)
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Red
            Console.WriteLine("                                         GAME OVER!")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.WriteLine("")
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("                            Press ENTER to Return to the Main Menu.")
            Console.ReadLine()
            Console.Clear()
            Main()
        End If

    End Sub
    Sub DrawSPBorder()

        For i = 1 To 79
            Console.Write("█")
        Next
        For j = 3 To 22
            Console.SetCursorPosition(40, j)
            Console.Write("░", 40, j)
        Next
        Console.WriteLine("")
        For i = 1 To 79
            Console.Write("█")
        Next

    End Sub
    Sub DrawPlayer(ByRef xpos As Integer, ByRef ypos As Integer)

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.SetCursorPosition(xpos, ypos)
        Console.Write("█", xpos, ypos)

    End Sub
    Sub DrawMinion(ByRef Mxpos() As Integer, ByRef Mypos() As Integer, ByRef mnum As Integer)

        Console.ForegroundColor = ConsoleColor.Red
        Console.SetCursorPosition(Mxpos(mnum), Mypos(mnum))
        Console.Write("┐▲", Mxpos(mnum), Mypos(mnum))

    End Sub
    Sub DrawMinionBullet(ByRef bulletx() As Integer, ByRef bullety() As Integer, ByRef tempmnum As Integer)

        If bulletx(tempmnum) <> 40 Then
            Console.ForegroundColor = ConsoleColor.White
            Console.SetCursorPosition(bulletx(tempmnum), bullety(tempmnum))
            Console.Write("←", bulletx(tempmnum), bullety(tempmnum))
        Else
            Console.ForegroundColor = ConsoleColor.White
            Console.SetCursorPosition(bulletx(tempmnum), bullety(tempmnum))
            Console.Write("░", bulletx(tempmnum), bullety(tempmnum))
        End If

    End Sub

End Module
