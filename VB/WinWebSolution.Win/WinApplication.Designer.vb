﻿Namespace WinWebSolution.Win
    Partial Public Class WinWebSolutionWindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New WinWebSolution.Module.WinWebSolutionModule()
            Me.module4 = New WinWebSolution.Module.Win.WinWebSolutionWindowsFormsModule()
            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.module7 = New DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule()
            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.schedulerWindowsFormsModule1 = New DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule()
            Me.schedulerModuleBase1 = New DevExpress.ExpressApp.Scheduler.SchedulerModuleBase()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module5
            ' 
            Me.module5.AllowValidationDetailsAccess = True
            Me.module5.IgnoreWarningAndInformationRules = False
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=WinWebSolution;Integrated Security=SSPI;Pooli" & "ng=false"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' WinWebSolutionWindowsFormsApplication
            ' 
            Me.ApplicationName = "WinWebSolution"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.module4)
            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.module7)
            Me.Modules.Add(Me.schedulerModuleBase1)
            Me.Modules.Add(Me.schedulerWindowsFormsModule1)
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As WinWebSolution.Module.WinWebSolutionModule
        Private module4 As WinWebSolution.Module.Win.WinWebSolutionWindowsFormsModule
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule
        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private module7 As DevExpress.ExpressApp.Validation.Win.ValidationWindowsFormsModule
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private schedulerWindowsFormsModule1 As DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule
        Private schedulerModuleBase1 As DevExpress.ExpressApp.Scheduler.SchedulerModuleBase
    End Class
End Namespace
