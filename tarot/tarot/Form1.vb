Public Class Form1
    Dim rand As New Random()
    Dim num As New Integer
    Dim num2 As New Integer
    Dim num3 As New Integer
    Dim num4 As New Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        Dim name As String
        Dim surname As String
        Dim age As Date

        name = InputBox("Give me your name")
        surname = InputBox("Give me your last name")
        age = InputBox("Give me your birth date")

        TextBox1.Text = (name & " here is your past!!!")
        TextBox4.Text = (name & " here is your present!!!")
        TextBox3.Text = (name & " here is what will happen in between!!!")
        TextBox2.Text = (name & " here is your future!!!")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        num = rand.Next(23)


        While num = Nothing
            num = rand.Next(23)
        End While

        PictureBox1.Image = My.Resources.ResourceManager.GetObject("tarot_" & num.ToString())

        If num = 10 Then
            TextBox1.Text = "THE FOOL
There was a new begging...you made the best of it...It was a time you lived your life to the fullest and tried to accomplish new goals! "
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 1 Then
            TextBox1.Text = "THE HIGH PRISTESS:
You had a very important dream or intuition that you should have paid attention to...It is connected with areas in your life that may be out of balance or that require greater foresight and wisdom!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 2 Then
            TextBox1.Text = "THE JUDGMENT:
You had a recent epiphany or an 'awakening' where you came to realisation that you need to live your life in a different way and you need to be true to yourself and your needs!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 3 Then
            TextBox1.Text = "THE JUSTICE:
You were in need to know and speak the truth and perceive it in the words and deeds of others!It was a time to remain objective an to base your judgment on facts and not on heresay! "
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 4 Then
            TextBox1.Text = "THE STRENGHT:
You gave others space and you were tolerant of their needs...You accepted and forgave any imperfections...You created a safe and trusting enviroment where you could gently influence others!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 5 Then
            TextBox1.Text = "DEATH:
You closed one door in order to open another...You put the past behind you and part ways ready to embrace new opportunities and possibilities!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 6 Then
            TextBox1.Text = "THE CHARIOT:
You were successful at pursuing your goals with determination and confidence in your abilities...and of cource with a lot of focus!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 7 Then
            TextBox1.Text = "THE DEVIL:
You may had been tricked into believing that you were being cotrolled by external forces when in fact have created your own chains of imprisonment and powerlessness!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 8 Then
            TextBox1.Text = "THE EMPRESS:
It represents pregnacy or birth...It could have been the birth of a new idea, a product or a new way of being!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 9 Then
            TextBox1.Text = "THE EMPEROR:
You had a strong desire to see your ideas manifested on the physical plane and the emperor ensured to sees it out until the end!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 11 Then
            TextBox1.Text = "THE HANGED MAN:
You had a need to get in touch with why you are feeling this way and worked to release yourself from these restrictions!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 12 Then
            TextBox1.Text = "THE HIEROPHANT:
You had a period of increased studying and learning,through formal mechanisms...You tried to understand a field of study that has been widely explored and documented..."
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 13 Then
            TextBox1.Text = "THE HERMIT:
You desired a new direction in life and have recently begun a journey of self-discovery and contemplation!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 14 Then
            TextBox1.Text = "THE LOVERS:
There was a time when you were figuring out what you stand foramd what your personal philosophy on life is!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 15 Then
            TextBox1.Text = "THE MAGICIAN:
You had the need to know what you were doing and why you were doing it...You needed to be clear adout your underlying motives and intetions!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 16 Then
            TextBox1.Text = "THE MOON:
You were experiencing negative blocks within your personality, causing fear and anxiety"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 17 Then
            TextBox1.Text = "THE STAR:
You had a strong desire to find or rediscover a sense of meaning , insiration or purpose in your life!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 19 Then
            TextBox1.Text = "THE TEMPERANCE:
You were able to work in harmony with others and there is a heightened level of co-operation in your activities with others!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 18 Then
            TextBox1.Text = "THE SUN:
No matter where you went or what you did your positive and radiant energy followed you and brought you happiness and joy! "
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 20 Then
            TextBox1.Text = "THE TOWER:
There was a time of great turmoil and destruction as you seeked to understand how you could have been so wrong, so naive, or so blind about a particularly situation!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 21 Then
            TextBox1.Text = "THE WHEEL OF FORTUNE:
There was a time when you needed to remain optimistic yourself,thinking positively and keeping upbeat as possible!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        ElseIf num = 22 Then
            TextBox1.Text = "THE WORLD:
All of your efforts finally paid off and you had reached the end of a journey or had completed a major live cyrcle!"
            TextBox1.TextAlign = HorizontalAlignment.Center
        End If



    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        num4 = rand.Next(1, 23)

        While num4 = Nothing
            num4 = rand.Next(23)
        End While
        If num4 <> num And num4 <> num2 And num4 <> num3 Then
            PictureBox5.Image = My.Resources.ResourceManager.GetObject("tarot_" & num4.ToString())

        ElseIf num4 = num Or num4 = num2 Or num4 = num3 Then

            While num4 = num Or num4 = num2 Or num4 = num3
                num4 = rand.Next(1, 23)
                PictureBox5.Image = My.Resources.ResourceManager.GetObject("tarot_" & num4.ToString())
            End While
        End If

        If num4 = 10 Then
            TextBox3.Text = "THE FOOL: 
There was a new begging...you made the best of it...It was a time you lived your life to the fullest and tried to accomplish new goals! "
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 1 Then
            TextBox3.Text = "THE HIGH PRISTESS:
You had a very important dream or intuition that you should have paid attention to...It is connected with areas in your life that may be out of balance or that require greater foresight and wisdom!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 2 Then
            TextBox3.Text = "THE JUDGMENT:
You had a recent epiphany or an 'awakening' where you came to realisation that you need to live your life in a different way and you need to be true to yourself and your needs!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 3 Then
            TextBox3.Text = "THE JUSTICE:
You were in need to know and speak the truth and perceive it in the words and deeds of others!It was a time to remain objective an to base your judgment on facts and not on heresay! "
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 4 Then
            TextBox3.Text = "THE STRENGHT:
You gave others space and you were tolerant of their needs...You accepted and forgave any imperfections...You created a safe and trusting enviroment where you could gently influence others!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 5 Then
            TextBox3.Text = "DEATH:
You closed one door in order to open another...You put the past behind you and part ways ready to embrace new opportunities and possibilities!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 6 Then
            TextBox3.Text = "THE CHARIOT:
You were successful at pursuing your goals with determination and confidence in your abilities...and of cource with a lot of focus!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 7 Then
            TextBox3.Text = "THE DEVIL:
You may had been tricked into believing that you were being cotrolled by external forces when in fact have created your own chains of imprisonment and powerlessness!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 8 Then
            TextBox3.Text = "THE EMPRESS:
It represents pregnacy or birth...It could have been the birth of a new idea, a product or a new way of being!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 9 Then
            TextBox3.Text = "THE EMPEROR:
You had a strong desire to see your ideas manifested on the physical plane and the emperor ensured to sees it out until the end!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 11 Then
            TextBox3.Text = "THE HANGED MAN:
You had a need to get in touch with why you are feeling this way and worked to release yourself from these restrictions!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 12 Then
            TextBox3.Text = "THE HIEROPHANT:
You had a period of increased studying and learning,through formal mechanisms...You tried to understand a field of study that has been widely explored and documented..."
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 13 Then
            TextBox3.Text = "THE HERMIT:
You desired a new direction in life and have recently begun a journey of self-discovery and contemplation!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 14 Then
            TextBox3.Text = "THE LOVERS:
There was a time when you were figuring out what you stand foramd what your personal philosophy on life is!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 15 Then
            TextBox3.Text = "THE MAGICIAN:
You had the need to know what you were doing and why you were doing it...You needed to be clear adout your underlying motives and intetions!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 16 Then
            TextBox3.Text = "THE MOON:
You were experiencing negative blocks within your personality, causing fear and anxiety"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 17 Then
            TextBox3.Text = "THE STAR:
You had a strong desire to find or rediscover a sense of meaning , insiration or purpose in your life!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 19 Then
            TextBox3.Text = "THE TEMPERANCE:
You were able to work in harmony with others and there is a heightened level of co-operation in your activities with others!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 18 Then
            TextBox3.Text = "THE SUN:
No matter where you went or what you did your positive and radiant energy followed you and brought you happiness and joy! "
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 20 Then
            TextBox3.Text = "THE TOWER:
There was a time of great turmoil and destruction as you seeked to understand how you could have been so wrong, so naive, or so blind about a particularly situation!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4 = 21 Then
            TextBox3.Text = "THE WHEEL OF FORTUNE:
There was a time when you needed to remain optimistic yourself,thinking positively and keeping upbeat as possible!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        ElseIf num4= 22 Then
            TextBox3.Text = "THE WORLD:
All of your efforts finally paid off and you had reached the end of a journey or had completed a major live cyrcle!"
            TextBox3.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        num3 = rand.Next(1, 23)

        While num3 = Nothing
            num3 = rand.Next(23)
        End While

        If num3 <> num And num3 <> num2 Then
            PictureBox4.Image = My.Resources.ResourceManager.GetObject("tarot_" & num3.ToString())
        ElseIf num3 = num Or num3 = num2 Then

            While num3 = num Or num3 = num2
                num3 = rand.Next(1, 23)
                PictureBox4.Image = My.Resources.ResourceManager.GetObject("tarot_" & num3.ToString())
            End While

        End If

        If num3 = 10 Then
            TextBox4.Text = "THE FOOL: 
Time for a new begging...you should make the best of it...It is a time to live your life to the fullest and try to accomplish new goals! "
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 1 Then
            TextBox4.Text = "THE HIGH PRISTESS:
You will see a very important dream or intuition that you should pay attention to...It is connected with areas in your life that may be out of balance or that require greater foresight and wisdom!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 2 Then
            TextBox4.Text = "THE JUDGMENT:
You had a recent epiphany or an 'awakening' where you came to realisation that you need to live your life in a different way and you need to be true to yourself and your needs!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 3 Then
            TextBox4.Text = "THE JUSTICE:
You are in need to know and speak the truth and perceive it in the words and deeds of others!It is a time to remain objective and to base your judgment on facts and not on heresay! "
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 4 Then
            TextBox4.Text = "THE STRENGHT:
You give others space and you are tolerant of their needs...You accept and forgive any imperfections...You create a safe and trusting enviroment where you can gently influence others!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 5 Then
            TextBox4.Text = "DEATH:
You close one door in order to open another...You put the past behind you and part ways ready to embrace new opportunities and possibilities!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 6 Then
            TextBox4.Text = "THE CHARIOT:
You will be successful at pursuing your goals with determination and confidence in your abilities...and of cource with a lot of focus!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 7 Then
            TextBox4.Text = "THE DEVIL:
You may have been tricked into believing that you have being cotrolled by external forces when in fact you have created your own chains of imprisonment and powerlessness!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 8 Then
            TextBox4.Text = "THE EMPRESS:
It represents pregnacy or birth...It can be the birth of a new idea, a product or a new way of being!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 9 Then
            TextBox4.Text = "THE EMPEROR:
You have a strong desire to see your ideas manifested on the physical plane and the emperor ensures to sees it out until the end!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 11 Then
            TextBox4.Text = "THE HANGED MAN:
You have a need to get in touch with why you are feeling this way and work to release yourself from these restrictions!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 12 Then
            TextBox4.Text = "THE HIEROPHANT:
You are having a period of increased studying and learning,through formal mechanisms...You try to understand a field of study that has been widely explored and documented..."
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 13 Then
            TextBox4.Text = "THE HERMIT:
You desire a new direction in life and have recently begun a journey of self-discovery and contemplation!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 14 Then
            TextBox4.Text = "THE LOVERS:
It is a time to figure out what you stand foramd what your personal philosophy on life is!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 15 Then
            TextBox4.Text = "THE MAGICIAN:
You have the need to know what you are doing and why you were doing it...You need to be clear adout your underlying motives and intetions!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 16 Then
            TextBox4.Text = "THE MOON:
You are experiencing negative blocks within your personality, causing fear and anxiety"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 17 Then
            TextBox4.Text = "THE STAR:
You have a strong desire to find or rediscover a sense of meaning , insiration or purpose in your life!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 19 Then
            TextBox4.Text = "THE TEMPERANCE:
You are able to work in harmony with others and there is a heightened level of co-operation in your activities with others!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 18 Then
            TextBox4.Text = "THE SUN:
No matter where you go or what you do your positive and radiant energy followed you and brought you happiness and joy! "
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 20 Then
            TextBox4.Text = "THE TOWER:
It is a time of great turmoil and destruction as you seek to understand how you could have been so wrong, so naive, or so blind about a particularly situation!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 21 Then
            TextBox4.Text = "THE WHEEL OF FORTUNE:
You needed to remain optimistic to yourself,thinking positively and keeping upbeat as possible!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        ElseIf num3 = 22 Then
            TextBox4.Text = "THE WORLD:
All of your efforts finally pay off and you are reaching the end of a journey or have completed a major live cyrcle!"
            TextBox4.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        num2 = rand.Next(1, 23)
        If num2 = Nothing Then
            num2 = rand.Next(1, 23)
        End If

        If num2 <> num Then
            PictureBox3.Image = My.Resources.ResourceManager.GetObject("tarot_" & num2.ToString())
        ElseIf num2 = num Then

            While num2 = num
                num2 = rand.Next(1, 23)
                PictureBox3.Image = My.Resources.ResourceManager.GetObject("tarot_" & num2.ToString())
            End While
        End If

        If num2 = 10 Then
            TextBox2.Text = "THE FOOL: 
There willcome a time for a new begging...you must make the best of it...It is a time you live your life to the fullest and try to accomplish new goals! "
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 1 Then
            TextBox2.Text = "THE HIGH PRISTESS:
You will have a very important dream or intuition that you should pay attention to...It is connected with areas in your life that may be out of balance or that require greater foresight and wisdom!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 2 Then
            TextBox2.Text = "THE JUDGMENT:
You will havean epiphany or an 'awakening' where you will come to realisation that you need to live your life in a different way and you need to be true to yourself and your needs!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 3 Then
            TextBox2.Text = "THE JUSTICE:
You will be in need to know and speak the truth and perceive it in the words and deeds of others!It will be a time to remain objective an to base your judgment on facts and not on heresay! "
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 4 Then
            TextBox2.Text = "THE STRENGHT:
You will give others space and you were tolerant of their needs...You will accept and forgive any imperfections...You will create a safe and trusting enviroment where you can gently influence others!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 5 Then
            TextBox2.Text = "DEATH:
You will close one door in order to open another...You will put the past behind you and part ways ready to embrace new opportunities and possibilities!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 6 Then
            TextBox2.Text = "THE CHARIOT:
You will be successful at pursuing your goals with determination and confidence in your abilities...and of cource with a lot of focus!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 7 Then
            TextBox2.Text = "THE DEVIL:
You will be tricked into believing that you are being cotrolled by external forces when in fact have created your own chains of imprisonment and powerlessness!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 8 Then
            TextBox2.Text = "THE EMPRESS:
It represents pregnacy or birth...It could be the birth of a new idea, a product or a new way of being!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 9 Then
            TextBox2.Text = "THE EMPEROR:
You will have a strong desire to see your ideas manifested on the physical plane and the emperor will be ensured to see it out until the end!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 11 Then
            TextBox2.Text = "THE HANGED MAN:
You will have the need to get in touch with why you are feeling this way and work to release yourself from these restrictions!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 12 Then
            TextBox2.Text = "THE HIEROPHANT:
You will have a period of increased studying and learning,through formal mechanisms...You will try to understand a field of study that has been widely explored and documented..."
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 13 Then
            TextBox2.Text = "THE HERMIT:
You will desire a new direction in life and begin a journey of self-discovery and contemplation!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 14 Then
            TextBox2.Text = "THE LOVERS:
There will be a time when you will be figuring out what you stand foramd what your personal philosophy on life is!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 15 Then
            TextBox2.Text = "THE MAGICIAN:
You will have the need to know what you are doing and why you are doing it...You need to be clear adout your underlying motives and intetions!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 16 Then
            TextBox2.Text = "THE MOON:
You will be experiencing negative blocks within your personality, causing fear and anxiety"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 17 Then
            TextBox2.Text = "THE STAR:
You will have a strong desire to find or rediscover a sense of meaning , insiration or purpose in your life!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 19 Then
            TextBox2.Text = "THE TEMPERANCE:
You will be able to work in harmony with others and there is a heightened level of co-operation in your activities with others!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 18 Then
            TextBox2.Text = "THE SUN:
No matter where you will go or what you'll do your positive and radiant energy will follow you and bring you happiness and joy! "
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 20 Then
            TextBox2.Text = "THE TOWER:
There will be a time of great turmoil and destruction as you will seek to understand how you could have been so wrong, so naive, or so blind about a particularly situation!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 21 Then
            TextBox2.Text = "THE WHEEL OF FORTUNE:
There will be a time when you will need to remain optimistic yourself,thinking positively and keeping upbeat as possible!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        ElseIf num2 = 22 Then
            TextBox2.Text = "THE WORLD:
All of your efforts will finally pay off and you will reach the end of a journey or you will complete a major live cyrcle!"
            TextBox2.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub
End Class
