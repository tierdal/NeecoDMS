﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Options
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Options))
        Me.button_ProductTypes = New System.Windows.Forms.Button()
        Me.button_PSL = New System.Windows.Forms.Button()
        Me.button_Sizes = New System.Windows.Forms.Button()
        Me.button_Styles = New System.Windows.Forms.Button()
        Me.button_TempClasses = New System.Windows.Forms.Button()
        Me.button_Trims = New System.Windows.Forms.Button()
        Me.button_PressureRatings = New System.Windows.Forms.Button()
        Me.button_PR = New System.Windows.Forms.Button()
        Me.button_Operators = New System.Windows.Forms.Button()
        Me.button_Exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'button_ProductTypes
        '
        Me.button_ProductTypes.Location = New System.Drawing.Point(12, 12)
        Me.button_ProductTypes.Name = "button_ProductTypes"
        Me.button_ProductTypes.Size = New System.Drawing.Size(130, 23)
        Me.button_ProductTypes.TabIndex = 1
        Me.button_ProductTypes.Text = "Edit Product Types"
        Me.button_ProductTypes.UseVisualStyleBackColor = True
        '
        'button_PSL
        '
        Me.button_PSL.Location = New System.Drawing.Point(12, 42)
        Me.button_PSL.Name = "button_PSL"
        Me.button_PSL.Size = New System.Drawing.Size(130, 23)
        Me.button_PSL.TabIndex = 2
        Me.button_PSL.Text = "Edit PSL"
        Me.button_PSL.UseVisualStyleBackColor = True
        '
        'button_Sizes
        '
        Me.button_Sizes.Location = New System.Drawing.Point(12, 71)
        Me.button_Sizes.Name = "button_Sizes"
        Me.button_Sizes.Size = New System.Drawing.Size(130, 23)
        Me.button_Sizes.TabIndex = 4
        Me.button_Sizes.Text = "Edit Sizes"
        Me.button_Sizes.UseVisualStyleBackColor = True
        '
        'button_Styles
        '
        Me.button_Styles.Location = New System.Drawing.Point(12, 101)
        Me.button_Styles.Name = "button_Styles"
        Me.button_Styles.Size = New System.Drawing.Size(130, 23)
        Me.button_Styles.TabIndex = 5
        Me.button_Styles.Text = "Edit Styles"
        Me.button_Styles.UseVisualStyleBackColor = True
        '
        'button_TempClasses
        '
        Me.button_TempClasses.Location = New System.Drawing.Point(12, 131)
        Me.button_TempClasses.Name = "button_TempClasses"
        Me.button_TempClasses.Size = New System.Drawing.Size(130, 23)
        Me.button_TempClasses.TabIndex = 6
        Me.button_TempClasses.Text = "Edit Temp Classes"
        Me.button_TempClasses.UseVisualStyleBackColor = True
        '
        'button_Trims
        '
        Me.button_Trims.Location = New System.Drawing.Point(148, 12)
        Me.button_Trims.Name = "button_Trims"
        Me.button_Trims.Size = New System.Drawing.Size(130, 23)
        Me.button_Trims.TabIndex = 7
        Me.button_Trims.Text = "Edit Trims"
        Me.button_Trims.UseVisualStyleBackColor = True
        '
        'button_PressureRatings
        '
        Me.button_PressureRatings.Location = New System.Drawing.Point(148, 42)
        Me.button_PressureRatings.Name = "button_PressureRatings"
        Me.button_PressureRatings.Size = New System.Drawing.Size(130, 23)
        Me.button_PressureRatings.TabIndex = 8
        Me.button_PressureRatings.Text = "Edit Pressure Ratings"
        Me.button_PressureRatings.UseVisualStyleBackColor = True
        '
        'button_PR
        '
        Me.button_PR.Location = New System.Drawing.Point(148, 72)
        Me.button_PR.Name = "button_PR"
        Me.button_PR.Size = New System.Drawing.Size(130, 23)
        Me.button_PR.TabIndex = 9
        Me.button_PR.Text = "Edit PR"
        Me.button_PR.UseVisualStyleBackColor = True
        '
        'button_Operators
        '
        Me.button_Operators.Location = New System.Drawing.Point(148, 102)
        Me.button_Operators.Name = "button_Operators"
        Me.button_Operators.Size = New System.Drawing.Size(130, 23)
        Me.button_Operators.TabIndex = 10
        Me.button_Operators.Text = "Edit Operator Styes"
        Me.button_Operators.UseVisualStyleBackColor = True
        '
        'button_Exit
        '
        Me.button_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_Exit.Location = New System.Drawing.Point(12, 180)
        Me.button_Exit.Name = "button_Exit"
        Me.button_Exit.Size = New System.Drawing.Size(266, 23)
        Me.button_Exit.TabIndex = 12
        Me.button_Exit.Text = "CLOSE"
        Me.button_Exit.UseVisualStyleBackColor = True
        '
        'form_Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_Exit
        Me.ClientSize = New System.Drawing.Size(289, 211)
        Me.Controls.Add(Me.button_Exit)
        Me.Controls.Add(Me.button_Operators)
        Me.Controls.Add(Me.button_PR)
        Me.Controls.Add(Me.button_PressureRatings)
        Me.Controls.Add(Me.button_Trims)
        Me.Controls.Add(Me.button_TempClasses)
        Me.Controls.Add(Me.button_Styles)
        Me.Controls.Add(Me.button_Sizes)
        Me.Controls.Add(Me.button_PSL)
        Me.Controls.Add(Me.button_ProductTypes)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "form_Options"
        Me.Text = "NeecoDMS - WO Options"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_ProductTypes As Button
    Friend WithEvents button_PSL As Button
    Friend WithEvents button_Sizes As Button
    Friend WithEvents button_Styles As Button
    Friend WithEvents button_TempClasses As Button
    Friend WithEvents button_Trims As Button
    Friend WithEvents button_PressureRatings As Button
    Friend WithEvents button_PR As Button
    Friend WithEvents button_Operators As Button
    Friend WithEvents button_Exit As Button
End Class
