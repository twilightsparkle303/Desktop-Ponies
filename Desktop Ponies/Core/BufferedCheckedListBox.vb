﻿''' <summary>
''' Displays a <see cref="ListBox"/> in which a check box is displayed to the left of each item. Double buffering is enabled.
''' </summary>
Public Class BufferedCheckedListBox
    Inherits CheckedListBox

    ''' <summary>
    ''' Initializes a new instance of the <see cref="BufferedCheckedListBox"/> class.
    ''' </summary>
    Public Sub New()
        DoubleBuffered = True
    End Sub
End Class
