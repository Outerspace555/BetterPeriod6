﻿Public Class Pentagon
    Public Property Pen As Pen
    Dim m_image As Image
    Dim m_a As Point
    Dim m_b As Point
    Dim points(4) As Point


    Public Sub New(i As Image, a As Point, b As Point)
        Pen = Pens.Red
        m_image = i
        m_a = a
        m_b = b
        points(0) = New Point(m_a.X - 20, m_a.Y)
        points(1) = New Point(m_a.X + 20, m_a.Y)
        points(2) = New Point(m_a.X + 20, m_a.Y + 20)
        points(3) = New Point(m_a.X, m_a.Y + 40)
        points(4) = New Point(m_a.X - 20, m_a.Y + 20)
    End Sub
    Public Sub Draw()
        Using g As Graphics = Graphics.FromImage(m_image)
            g.DrawPolygon(Pen, points)
        End Using

    End Sub

End Class
