#Region "Using directives"
Imports System
Imports System.Windows.Forms
Imports System.Collections
Imports System.Reflection
Imports aQueryLib
Imports aQueryLib.aQueryLib

#End Region

Namespace ServerTest
    Class MainForm
        Inherits System.Windows.Forms.Form
        Private components As System.ComponentModel.IContainer = Nothing
        Private lvPlayers As System.Windows.Forms.ListView
        Private lvParams As System.Windows.Forms.ListView
        Private colName As System.Windows.Forms.ColumnHeader
        Private colScore As System.Windows.Forms.ColumnHeader
        Private colPing As System.Windows.Forms.ColumnHeader
        Private colTime As System.Windows.Forms.ColumnHeader
        Private colKey As System.Windows.Forms.ColumnHeader
        Private colVal As System.Windows.Forms.ColumnHeader
        Friend WithEvents listviewServers As System.Windows.Forms.ListView
        Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
        Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
        Friend WithEvents buttonCancelQuery As System.Windows.Forms.Button
        Private tbInfos As System.Windows.Forms.TextBox
        Friend WithEvents buttonRefresh As System.Windows.Forms.Button
        Friend WithEvents comboGame As System.Windows.Forms.ComboBox
        Friend WithEvents Label1 As System.Windows.Forms.Label
        Friend WithEvents Label2 As System.Windows.Forms.Label
        Friend WithEvents textMap As System.Windows.Forms.TextBox
        Friend WithEvents Label3 As System.Windows.Forms.Label
        Friend WithEvents comboLocation As System.Windows.Forms.ComboBox
        Friend WithEvents checkNotFull As System.Windows.Forms.CheckBox
        Friend WithEvents checkSecure As System.Windows.Forms.CheckBox
        Friend WithEvents checkNotEmpty As System.Windows.Forms.CheckBox
        Friend WithEvents checkLinux As System.Windows.Forms.CheckBox
        Friend WithEvents checkDedicated As System.Windows.Forms.CheckBox
        Friend WithEvents checkWhitelisted As System.Windows.Forms.CheckBox
        Friend WithEvents checkSpectatorProxy As System.Windows.Forms.CheckBox
        Friend WithEvents checkEmpty As System.Windows.Forms.CheckBox
        Friend WithEvents textMod As System.Windows.Forms.TextBox
        Friend WithEvents Label4 As System.Windows.Forms.Label

        Private masterQuery As SourceMasterServer
        Friend WithEvents txtHost As System.Windows.Forms.TextBox
        Friend WithEvents lblHost As System.Windows.Forms.Label
        Friend WithEvents Label5 As System.Windows.Forms.Label
        Friend WithEvents btnQuery As System.Windows.Forms.Button
        Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
        Friend WithEvents cboGame As System.Windows.Forms.ComboBox
        Friend WithEvents Label6 As System.Windows.Forms.Label

        Private serverListItems As List(Of ListViewItem)

        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"
        Private Sub InitializeComponent()
            Me.lvPlayers = New System.Windows.Forms.ListView
            Me.colName = New System.Windows.Forms.ColumnHeader
            Me.colScore = New System.Windows.Forms.ColumnHeader
            Me.colPing = New System.Windows.Forms.ColumnHeader
            Me.colTime = New System.Windows.Forms.ColumnHeader
            Me.lvParams = New System.Windows.Forms.ListView
            Me.colKey = New System.Windows.Forms.ColumnHeader
            Me.colVal = New System.Windows.Forms.ColumnHeader
            Me.tbInfos = New System.Windows.Forms.TextBox
            Me.listviewServers = New System.Windows.Forms.ListView
            Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
            Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
            Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
            Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
            Me.buttonCancelQuery = New System.Windows.Forms.Button
            Me.buttonRefresh = New System.Windows.Forms.Button
            Me.comboGame = New System.Windows.Forms.ComboBox
            Me.Label1 = New System.Windows.Forms.Label
            Me.Label2 = New System.Windows.Forms.Label
            Me.textMap = New System.Windows.Forms.TextBox
            Me.Label3 = New System.Windows.Forms.Label
            Me.comboLocation = New System.Windows.Forms.ComboBox
            Me.checkNotFull = New System.Windows.Forms.CheckBox
            Me.checkSecure = New System.Windows.Forms.CheckBox
            Me.checkNotEmpty = New System.Windows.Forms.CheckBox
            Me.checkLinux = New System.Windows.Forms.CheckBox
            Me.checkDedicated = New System.Windows.Forms.CheckBox
            Me.checkWhitelisted = New System.Windows.Forms.CheckBox
            Me.checkSpectatorProxy = New System.Windows.Forms.CheckBox
            Me.checkEmpty = New System.Windows.Forms.CheckBox
            Me.textMod = New System.Windows.Forms.TextBox
            Me.Label4 = New System.Windows.Forms.Label
            Me.txtHost = New System.Windows.Forms.TextBox
            Me.lblHost = New System.Windows.Forms.Label
            Me.Label5 = New System.Windows.Forms.Label
            Me.btnQuery = New System.Windows.Forms.Button
            Me.GroupBox1 = New System.Windows.Forms.GroupBox
            Me.cboGame = New System.Windows.Forms.ComboBox
            Me.Label6 = New System.Windows.Forms.Label
            Me.GroupBox1.SuspendLayout()
            Me.SuspendLayout()
            '
            'lvPlayers
            '
            Me.lvPlayers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colName, Me.colScore, Me.colPing, Me.colTime})
            Me.lvPlayers.FullRowSelect = True
            Me.lvPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.lvPlayers.Location = New System.Drawing.Point(12, 81)
            Me.lvPlayers.Name = "lvPlayers"
            Me.lvPlayers.Size = New System.Drawing.Size(268, 245)
            Me.lvPlayers.TabIndex = 4
            Me.lvPlayers.UseCompatibleStateImageBehavior = False
            Me.lvPlayers.View = System.Windows.Forms.View.Details
            '
            'colName
            '
            Me.colName.Text = "Name"
            Me.colName.Width = 83
            '
            'colScore
            '
            Me.colScore.Text = "Score"
            '
            'colPing
            '
            Me.colPing.Text = "Ping"
            '
            'colTime
            '
            Me.colTime.Text = "Time"
            '
            'lvParams
            '
            Me.lvParams.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKey, Me.colVal})
            Me.lvParams.FullRowSelect = True
            Me.lvParams.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
            Me.lvParams.Location = New System.Drawing.Point(286, 81)
            Me.lvParams.Name = "lvParams"
            Me.lvParams.Size = New System.Drawing.Size(217, 243)
            Me.lvParams.TabIndex = 5
            Me.lvParams.UseCompatibleStateImageBehavior = False
            Me.lvParams.View = System.Windows.Forms.View.Details
            '
            'colKey
            '
            Me.colKey.Text = "key"
            Me.colKey.Width = 108
            '
            'colVal
            '
            Me.colVal.Text = "val"
            Me.colVal.Width = 105
            '
            'tbInfos
            '
            Me.tbInfos.Location = New System.Drawing.Point(509, 81)
            Me.tbInfos.Multiline = True
            Me.tbInfos.Name = "tbInfos"
            Me.tbInfos.Size = New System.Drawing.Size(174, 243)
            Me.tbInfos.TabIndex = 7
            '
            'listviewServers
            '
            Me.listviewServers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
            Me.listviewServers.FullRowSelect = True
            Me.listviewServers.Location = New System.Drawing.Point(12, 339)
            Me.listviewServers.Name = "listviewServers"
            Me.listviewServers.Size = New System.Drawing.Size(476, 259)
            Me.listviewServers.TabIndex = 8
            Me.listviewServers.UseCompatibleStateImageBehavior = False
            Me.listviewServers.View = System.Windows.Forms.View.Details
            '
            'ColumnHeader1
            '
            Me.ColumnHeader1.Text = "Name"
            Me.ColumnHeader1.Width = 190
            '
            'ColumnHeader2
            '
            Me.ColumnHeader2.Text = "Game"
            Me.ColumnHeader2.Width = 104
            '
            'ColumnHeader3
            '
            Me.ColumnHeader3.Text = "Players"
            Me.ColumnHeader3.Width = 70
            '
            'ColumnHeader4
            '
            Me.ColumnHeader4.Text = "Map"
            Me.ColumnHeader4.Width = 106
            '
            'buttonCancelQuery
            '
            Me.buttonCancelQuery.Enabled = False
            Me.buttonCancelQuery.Location = New System.Drawing.Point(595, 575)
            Me.buttonCancelQuery.Name = "buttonCancelQuery"
            Me.buttonCancelQuery.Size = New System.Drawing.Size(87, 23)
            Me.buttonCancelQuery.TabIndex = 9
            Me.buttonCancelQuery.Text = "Cancel refresh"
            Me.buttonCancelQuery.UseVisualStyleBackColor = True
            '
            'buttonRefresh
            '
            Me.buttonRefresh.Location = New System.Drawing.Point(509, 575)
            Me.buttonRefresh.Name = "buttonRefresh"
            Me.buttonRefresh.Size = New System.Drawing.Size(73, 23)
            Me.buttonRefresh.TabIndex = 10
            Me.buttonRefresh.Text = "Refresh"
            Me.buttonRefresh.UseVisualStyleBackColor = True
            '
            'comboGame
            '
            Me.comboGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboGame.FormattingEnabled = True
            Me.comboGame.Items.AddRange(New Object() {"Source", "Half-Life"})
            Me.comboGame.Location = New System.Drawing.Point(547, 336)
            Me.comboGame.Name = "comboGame"
            Me.comboGame.Size = New System.Drawing.Size(121, 21)
            Me.comboGame.TabIndex = 11
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Location = New System.Drawing.Point(506, 339)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(35, 13)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Game"
            '
            'Label2
            '
            Me.Label2.AutoSize = True
            Me.Label2.Location = New System.Drawing.Point(513, 371)
            Me.Label2.Name = "Label2"
            Me.Label2.Size = New System.Drawing.Size(28, 13)
            Me.Label2.TabIndex = 13
            Me.Label2.Text = "Map"
            '
            'textMap
            '
            Me.textMap.Location = New System.Drawing.Point(547, 368)
            Me.textMap.Name = "textMap"
            Me.textMap.Size = New System.Drawing.Size(118, 20)
            Me.textMap.TabIndex = 14
            '
            'Label3
            '
            Me.Label3.AutoSize = True
            Me.Label3.Location = New System.Drawing.Point(493, 431)
            Me.Label3.Name = "Label3"
            Me.Label3.Size = New System.Drawing.Size(48, 13)
            Me.Label3.TabIndex = 15
            Me.Label3.Text = "Location"
            '
            'comboLocation
            '
            Me.comboLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.comboLocation.FormattingEnabled = True
            Me.comboLocation.Location = New System.Drawing.Point(547, 428)
            Me.comboLocation.Name = "comboLocation"
            Me.comboLocation.Size = New System.Drawing.Size(124, 21)
            Me.comboLocation.TabIndex = 16
            '
            'checkNotFull
            '
            Me.checkNotFull.AutoSize = True
            Me.checkNotFull.Location = New System.Drawing.Point(509, 455)
            Me.checkNotFull.Name = "checkNotFull"
            Me.checkNotFull.Size = New System.Drawing.Size(62, 17)
            Me.checkNotFull.TabIndex = 17
            Me.checkNotFull.Text = "Not Full"
            Me.checkNotFull.UseVisualStyleBackColor = True
            '
            'checkSecure
            '
            Me.checkSecure.AutoSize = True
            Me.checkSecure.Location = New System.Drawing.Point(509, 501)
            Me.checkSecure.Name = "checkSecure"
            Me.checkSecure.Size = New System.Drawing.Size(60, 17)
            Me.checkSecure.TabIndex = 18
            Me.checkSecure.Text = "Secure"
            Me.checkSecure.UseVisualStyleBackColor = True
            '
            'checkNotEmpty
            '
            Me.checkNotEmpty.AutoSize = True
            Me.checkNotEmpty.Location = New System.Drawing.Point(509, 478)
            Me.checkNotEmpty.Name = "checkNotEmpty"
            Me.checkNotEmpty.Size = New System.Drawing.Size(75, 17)
            Me.checkNotEmpty.TabIndex = 19
            Me.checkNotEmpty.Text = "Not Empty"
            Me.checkNotEmpty.UseVisualStyleBackColor = True
            '
            'checkLinux
            '
            Me.checkLinux.AutoSize = True
            Me.checkLinux.Location = New System.Drawing.Point(602, 455)
            Me.checkLinux.Name = "checkLinux"
            Me.checkLinux.Size = New System.Drawing.Size(79, 17)
            Me.checkLinux.TabIndex = 20
            Me.checkLinux.Text = "Runs Linux"
            Me.checkLinux.UseVisualStyleBackColor = True
            '
            'checkDedicated
            '
            Me.checkDedicated.AutoSize = True
            Me.checkDedicated.Location = New System.Drawing.Point(602, 478)
            Me.checkDedicated.Name = "checkDedicated"
            Me.checkDedicated.Size = New System.Drawing.Size(75, 17)
            Me.checkDedicated.TabIndex = 21
            Me.checkDedicated.Text = "Dedicated"
            Me.checkDedicated.UseVisualStyleBackColor = True
            '
            'checkWhitelisted
            '
            Me.checkWhitelisted.AutoSize = True
            Me.checkWhitelisted.Location = New System.Drawing.Point(602, 501)
            Me.checkWhitelisted.Name = "checkWhitelisted"
            Me.checkWhitelisted.Size = New System.Drawing.Size(81, 17)
            Me.checkWhitelisted.TabIndex = 22
            Me.checkWhitelisted.Text = "White-listed"
            Me.checkWhitelisted.UseVisualStyleBackColor = True
            '
            'checkSpectatorProxy
            '
            Me.checkSpectatorProxy.AutoSize = True
            Me.checkSpectatorProxy.Location = New System.Drawing.Point(509, 524)
            Me.checkSpectatorProxy.Name = "checkSpectatorProxy"
            Me.checkSpectatorProxy.Size = New System.Drawing.Size(101, 17)
            Me.checkSpectatorProxy.TabIndex = 23
            Me.checkSpectatorProxy.Text = "Spectator Proxy"
            Me.checkSpectatorProxy.UseVisualStyleBackColor = True
            '
            'checkEmpty
            '
            Me.checkEmpty.AutoSize = True
            Me.checkEmpty.Location = New System.Drawing.Point(509, 547)
            Me.checkEmpty.Name = "checkEmpty"
            Me.checkEmpty.Size = New System.Drawing.Size(66, 17)
            Me.checkEmpty.TabIndex = 24
            Me.checkEmpty.Text = "Is Empty"
            Me.checkEmpty.UseVisualStyleBackColor = True
            '
            'textMod
            '
            Me.textMod.Location = New System.Drawing.Point(547, 397)
            Me.textMod.Name = "textMod"
            Me.textMod.Size = New System.Drawing.Size(118, 20)
            Me.textMod.TabIndex = 25
            '
            'Label4
            '
            Me.Label4.AutoSize = True
            Me.Label4.Location = New System.Drawing.Point(513, 400)
            Me.Label4.Name = "Label4"
            Me.Label4.Size = New System.Drawing.Size(28, 13)
            Me.Label4.TabIndex = 26
            Me.Label4.Text = "Mod"
            '
            'txtHost
            '
            Me.txtHost.Location = New System.Drawing.Point(76, 21)
            Me.txtHost.Name = "txtHost"
            Me.txtHost.Size = New System.Drawing.Size(168, 20)
            Me.txtHost.TabIndex = 27
            '
            'lblHost
            '
            Me.lblHost.AutoSize = True
            Me.lblHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblHost.Location = New System.Drawing.Point(13, 24)
            Me.lblHost.Name = "lblHost"
            Me.lblHost.Size = New System.Drawing.Size(57, 13)
            Me.lblHost.TabIndex = 28
            Me.lblHost.Text = "IP:PORT"
            '
            'Label5
            '
            Me.Label5.AutoSize = True
            Me.Label5.Location = New System.Drawing.Point(62, 44)
            Me.Label5.Name = "Label5"
            Me.Label5.Size = New System.Drawing.Size(132, 13)
            Me.Label5.TabIndex = 29
            Me.Label5.Text = "(i.e. 192.168.2.100:27015)"
            '
            'btnQuery
            '
            Me.btnQuery.Location = New System.Drawing.Point(561, 15)
            Me.btnQuery.Name = "btnQuery"
            Me.btnQuery.Size = New System.Drawing.Size(98, 44)
            Me.btnQuery.TabIndex = 30
            Me.btnQuery.Text = "Query Server"
            Me.btnQuery.UseVisualStyleBackColor = True
            '
            'GroupBox1
            '
            Me.GroupBox1.Controls.Add(Me.Label6)
            Me.GroupBox1.Controls.Add(Me.cboGame)
            Me.GroupBox1.Controls.Add(Me.lblHost)
            Me.GroupBox1.Controls.Add(Me.btnQuery)
            Me.GroupBox1.Controls.Add(Me.txtHost)
            Me.GroupBox1.Controls.Add(Me.Label5)
            Me.GroupBox1.Location = New System.Drawing.Point(12, 6)
            Me.GroupBox1.Name = "GroupBox1"
            Me.GroupBox1.Size = New System.Drawing.Size(669, 69)
            Me.GroupBox1.TabIndex = 31
            Me.GroupBox1.TabStop = False
            Me.GroupBox1.Text = "Single Server Query"
            '
            'cboGame
            '
            Me.cboGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.cboGame.FormattingEnabled = True
            Me.cboGame.Items.AddRange(New Object() {"Source", "Half-Life"})
            Me.cboGame.Location = New System.Drawing.Point(327, 22)
            Me.cboGame.Name = "cboGame"
            Me.cboGame.Size = New System.Drawing.Size(218, 21)
            Me.cboGame.TabIndex = 31
            '
            'Label6
            '
            Me.Label6.AutoSize = True
            Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label6.Location = New System.Drawing.Point(250, 25)
            Me.Label6.Name = "Label6"
            Me.Label6.Size = New System.Drawing.Size(71, 13)
            Me.Label6.TabIndex = 32
            Me.Label6.Text = "Game Type"
            '
            'MainForm
            '
            Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
            Me.ClientSize = New System.Drawing.Size(694, 604)
            Me.Controls.Add(Me.GroupBox1)
            Me.Controls.Add(Me.Label4)
            Me.Controls.Add(Me.textMod)
            Me.Controls.Add(Me.checkEmpty)
            Me.Controls.Add(Me.checkSpectatorProxy)
            Me.Controls.Add(Me.checkWhitelisted)
            Me.Controls.Add(Me.checkDedicated)
            Me.Controls.Add(Me.checkLinux)
            Me.Controls.Add(Me.checkNotEmpty)
            Me.Controls.Add(Me.checkSecure)
            Me.Controls.Add(Me.checkNotFull)
            Me.Controls.Add(Me.comboLocation)
            Me.Controls.Add(Me.Label3)
            Me.Controls.Add(Me.textMap)
            Me.Controls.Add(Me.Label2)
            Me.Controls.Add(Me.Label1)
            Me.Controls.Add(Me.comboGame)
            Me.Controls.Add(Me.buttonRefresh)
            Me.Controls.Add(Me.buttonCancelQuery)
            Me.Controls.Add(Me.listviewServers)
            Me.Controls.Add(Me.tbInfos)
            Me.Controls.Add(Me.lvParams)
            Me.Controls.Add(Me.lvPlayers)
            Me.DoubleBuffered = True
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
            Me.Name = "MainForm"
            Me.Text = "Form1"
            Me.GroupBox1.ResumeLayout(False)
            Me.GroupBox1.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Public Sub New()
            InitializeComponent()

            ' Bind the region types to comboLocation
            comboLocation.DataSource = [Enum].GetNames(GetType(SourceMasterServer.QueryRegionCode))
            comboLocation.SelectedIndex = 0
            Dim items As String() = [Enum].GetNames(GetType(GameType))
            Array.Sort(items)
            cboGame.DataSource = items
            cboGame.SelectedIndex = 0

            Me.serverListItems = New List(Of ListViewItem)

            Me.masterQuery = New SourceMasterServer()
            Me.masterQuery.SynchronizingObject = Me
            AddHandler Me.masterQuery.QueryAsyncCompleted, AddressOf Me.SourceMasterServer_QueryAsyncCompleted

        End Sub

        Private Sub SourceMasterServer_QueryAsyncCompleted(ByVal sender As Object, ByVal e As System.EventArgs)
            buttonCancelQuery.Enabled = False
            buttonRefresh.Enabled = True
        End Sub

        Private Sub SourceMasterQuery_Callback(ByVal sender As Object, ByVal e As SourceMasterServer.QueryAsyncEventArgs)
            Dim item As New ListViewItem(New String() {e.GameServer.Name, e.GameServer.Mod, String.Format("{0} / {1}", e.GameServer.NumPlayers, e.GameServer.MaxPlayers), e.GameServer.Map})
            item.Tag = e.GameServer
            Me.serverListItems.Add(item)
            Me.AddServerListItem(item)
        End Sub

        ' This method will add an item to the server list ONLY if it
        ' passes the filters set. It will only check the parameters that
        ' can change "quickly", such as if the server is empty or not.
        ' An example of parameter that can not change "quickly" is whether or
        ' not the server runs linux.
        Private Sub AddServerListItem(ByVal item As ListViewItem)
            Dim server As GameServer = DirectCast(item.Tag, GameServer)
            If Me.checkNotEmpty.Checked AndAlso server.Players.Count = 0 Then
                ' Server is empty, and is thus filtered out.
                Return
            End If

            If Me.checkEmpty.Checked AndAlso server.Players.Count > 0 Then
                ' Server is not empty, and is thus filtered out.
                Return
            End If

            If Me.checkNotFull.Checked AndAlso server.Players.Count = server.MaxPlayers Then
                ' Server is full, and is thus filtered out.
                Return
            End If

            ' If we've reached this far, the server has passed the filters.
            Me.listviewServers.Items.Add(item)
        End Sub

        Private Sub UpdateServerList()
            Me.listviewServers.Items.Clear()
            Dim filteredItems As IEnumerable(Of ListViewItem) 
            If Me.checkDedicated.Checked Then
                filteredItems = From item As ListViewItem In Me.serverListItems _
                                Let server = DirectCast(item.Tag, GameServer) _
                                Where server.Parameters("servertype") = "d" _
                                Select item
            Else
                filteredItems = From item As ListViewItem In Me.serverListItems _
                                Select item
            End If

            If Me.checkEmpty.Checked Then
                filteredItems = From item As ListViewItem In filteredItems _
                                Let server = DirectCast(item.Tag, GameServer) _
                                Where server.Players.Count = 0 _
                                Select item
            End If

            If Me.checkLinux.Checked Then
                filteredItems = From item As ListViewItem In filteredItems _
                                Let server = DirectCast(item.Tag, GameServer) _
                                Where server.Parameters("serveros") = "l" _
                                Select item
            End If

            If Me.checkNotEmpty.Checked Then
                filteredItems = From item As ListViewItem In filteredItems _
                                Let server = DirectCast(item.Tag, GameServer) _
                                Where server.Players.Count > 0 _
                                Select item
            End If

            If Me.checkNotFull.Checked Then
                filteredItems = From item As ListViewItem In filteredItems _
                                Let server = DirectCast(item.Tag, GameServer) _
                                Where server.Players.Count < server.MaxPlayers _
                                Select item
            End If

            If Me.checkSecure.Checked Then
                filteredItems = From item As ListViewItem In filteredItems _
                                               Let server = DirectCast(item.Tag, GameServer) _
                                               Where server.Parameters("secured") = "1" _
                                               Select item
            End If

            If Me.textMap.Text <> String.Empty Then
                filteredItems = From item As ListViewItem In filteredItems _
                                              Let server = DirectCast(item.Tag, GameServer) _
                                              Where server.Map Like Me.textMap.Text _
                                              Select item
            End If

            If Me.textMod.Text <> String.Empty Then
                filteredItems = From item As ListViewItem In filteredItems _
                                              Let server = DirectCast(item.Tag, GameServer) _
                                              Where server.Map Like Me.textMod.Text _
                                              Select item
            End If

            Me.listviewServers.Items.AddRange(filteredItems.ToArray())
        End Sub

        Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            comboGame.SelectedIndex = 0
        End Sub


        Private Sub cancelQueryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonCancelQuery.Click
            masterQuery.CancelAsyncQuery()
        End Sub

        Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonRefresh.Click
            Dim filter As SourceMasterServer.QueryFilter = SourceMasterServer.QueryFilter.None
            Dim game As SourceMasterServer.QueryGame

            listviewServers.Items.Clear()
            Me.serverListItems.Clear()

            If comboGame.SelectedIndex = 0 Then
                game = SourceMasterServer.QueryGame.Source
            Else
                game = SourceMasterServer.QueryGame.HalfLife
            End If
            Dim region As SourceMasterServer.QueryRegionCode = CType([Enum].Parse(GetType(SourceMasterServer.QueryRegionCode), DirectCast(comboLocation.SelectedItem, String)), SourceMasterServer.QueryRegionCode)

            If checkDedicated.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.Dedicated
            End If
            If checkLinux.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.Linux
            End If
            If checkNotEmpty.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.NotEmpty
            End If
            If checkNotFull.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.NotFull
            End If
            If checkSecure.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.AntiCheat
            End If
            If checkSpectatorProxy.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.SpectatorProxies
            End If
            If checkWhitelisted.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.WhiteListed
            End If
            If checkEmpty.Checked Then
                filter = filter Or SourceMasterServer.QueryFilter.Empty
            End If

            masterQuery.QueryAsync(game, region, filter, textMap.Text.Trim(), textMod.Text.Trim(), AddressOf SourceMasterQuery_Callback)
            Me.buttonRefresh.Enabled = False
            Me.buttonCancelQuery.Enabled = True
        End Sub

        Private Sub listviewServers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listviewServers.SelectedIndexChanged
            If Me.listviewServers.SelectedItems.Count > 0 Then
                Dim server As GameServer = DirectCast(Me.listviewServers.SelectedItems(0).Tag, GameServer)
                Me.lvPlayers.Items.Clear()
                Me.lvParams.Items.Clear()
                Me.tbInfos.Clear()

                For Each player As aQueryLib.aQueryLib.Player In server.Players
                    Dim lvItem As New ListViewItem(New String() {GameServer.CleanName(player.Name), player.Score.ToString(), player.Ping.ToString(), player.Time.ToString()})
                    Me.lvPlayers.Items.Add(lvItem)
                Next

                For Each de As DictionaryEntry In server.Parameters
                    Dim lvItem As New ListViewItem(New String() {de.Key.ToString(), de.Value.ToString()})
                    lvParams.Items.Add(lvItem)
                Next

                Dim props As PropertyInfo() = server.[GetType]().GetProperties(BindingFlags.[Public] Or BindingFlags.GetField Or BindingFlags.Instance)
                For Each prop As PropertyInfo In props
                    Try
                        Dim obj As Object = prop.GetValue(server, Nothing)
                        If obj.ToString().IndexOf("Collection") <> -1 Then
                            Continue For
                        End If
                        tbInfos.Text += (prop.Name & " - ") + obj.ToString() & vbCr & vbLf
                    Catch generatedExceptionName As TargetInvocationException
                    Catch generatedExceptionName As NullReferenceException
                    End Try
                Next
            End If
        End Sub

        Private Sub checkEmpty_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkEmpty.CheckedChanged, checkSecure.CheckedChanged, checkDedicated.CheckedChanged, checkNotEmpty.CheckedChanged, checkLinux.CheckedChanged, checkNotFull.CheckedChanged, textMod.TextChanged, textMap.TextChanged
            Me.UpdateServerList()
        End Sub

        Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
            If Trim(txtHost.Text) = Nothing Then Exit Sub
            Try
                Dim splithost As String() = Split(Trim(txtHost.Text), ":")
                If splithost(0).ToString = Nothing Or splithost(1).ToString = Nothing Then Exit Sub

                Dim gtype As GameType = Nothing
                If cboGame.SelectedItem.ToString = "Source" Then
                    gtype = GameType.Source
                Else
                    gtype = GameType.HalfLife
                End If

                Dim server As New GameServer(splithost(0).ToString, CInt(splithost(1).ToString), gtype)
                server.QueryServer()

                Me.lvPlayers.Items.Clear()
                Me.lvParams.Items.Clear()
                Me.tbInfos.Clear()

                For Each player As aQueryLib.aQueryLib.Player In server.Players
                    Dim lvItem As New ListViewItem(New String() {GameServer.CleanName(player.Name), player.Score.ToString(), player.Ping.ToString(), player.Time.ToString()})
                    Me.lvPlayers.Items.Add(lvItem)
                Next

                For Each de As DictionaryEntry In server.Parameters
                    Dim lvItem As New ListViewItem(New String() {de.Key.ToString(), de.Value.ToString()})
                    lvParams.Items.Add(lvItem)
                Next

                Dim props As PropertyInfo() = server.[GetType]().GetProperties(BindingFlags.[Public] Or BindingFlags.GetField Or BindingFlags.Instance)
                For Each prop As PropertyInfo In props
                    Try
                        Dim obj As Object = prop.GetValue(server, Nothing)
                        If obj.ToString().IndexOf("Collection") <> -1 Then
                            Continue For
                        End If
                        tbInfos.Text += (prop.Name & " - ") + obj.ToString() & vbCr & vbLf
                    Catch generatedExceptionName As TargetInvocationException
                    Catch generatedExceptionName As NullReferenceException
                    End Try
                Next
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
            End Try
        End Sub
    End Class
End Namespace
