<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LeMenu
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
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

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LeMenu))
        Me.TabControl1 = New JacksiroKe.MdiTabCtrl.TabControl()
        Me.ListaRzeczy = New System.Windows.Forms.MenuStrip()
        Me.ItemsOpcje = New System.Windows.Forms.ToolStripMenuItem()
        Me.ItemsInformacje = New System.Windows.Forms.ToolStripMenuItem()
        Me.OProgramieItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RozpocznijToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZatrzymajToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZresetujCzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GospodarzeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GościeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NadajNazwęToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajPunktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdejmijPunktToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UstawieniaDlaGospodarzyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NadajNazwęToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DodajPunktToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OdejmijPunktToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UstawieniaDlaGościaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabelaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ĄToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UstawieniaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ZrestartujLiczenieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegEditorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WyjścieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UstawCzasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaRzeczy.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 362)
        Me.TabControl1.MenuRenderer = Nothing
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.Size = New System.Drawing.Size(824, 175)
        Me.TabControl1.TabCloseButtonImage = Nothing
        Me.TabControl1.TabCloseButtonImageDisabled = Nothing
        Me.TabControl1.TabCloseButtonImageHot = Nothing
        Me.TabControl1.TabIndex = 0
        '
        'ListaRzeczy
        '
        Me.ListaRzeczy.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ItemsOpcje, Me.GospodarzeToolStripMenuItem, Me.CzasToolStripMenuItem, Me.GościeToolStripMenuItem, Me.ItemsInformacje})
        Me.ListaRzeczy.Location = New System.Drawing.Point(0, 0)
        Me.ListaRzeczy.Name = "ListaRzeczy"
        Me.ListaRzeczy.Size = New System.Drawing.Size(824, 24)
        Me.ListaRzeczy.TabIndex = 1
        '
        'ItemsOpcje
        '
        Me.ItemsOpcje.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TabelaToolStripMenuItem, Me.ZrestartujLiczenieToolStripMenuItem, Me.RegEditorToolStripMenuItem, Me.WyjścieToolStripMenuItem})
        Me.ItemsOpcje.Name = "ItemsOpcje"
        Me.ItemsOpcje.Size = New System.Drawing.Size(50, 20)
        Me.ItemsOpcje.Text = "Opcje"
        '
        'ItemsInformacje
        '
        Me.ItemsInformacje.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OProgramieItem})
        Me.ItemsInformacje.Name = "ItemsInformacje"
        Me.ItemsInformacje.Size = New System.Drawing.Size(76, 20)
        Me.ItemsInformacje.Text = "Informacje"
        '
        'OProgramieItem
        '
        Me.OProgramieItem.Name = "OProgramieItem"
        Me.OProgramieItem.Size = New System.Drawing.Size(180, 22)
        Me.OProgramieItem.Text = "O programie"
        '
        'CzasToolStripMenuItem
        '
        Me.CzasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RozpocznijToolStripMenuItem, Me.ZatrzymajToolStripMenuItem, Me.ZresetujCzasToolStripMenuItem, Me.UstawCzasToolStripMenuItem})
        Me.CzasToolStripMenuItem.Name = "CzasToolStripMenuItem"
        Me.CzasToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.CzasToolStripMenuItem.Text = "Czas"
        '
        'RozpocznijToolStripMenuItem
        '
        Me.RozpocznijToolStripMenuItem.Name = "RozpocznijToolStripMenuItem"
        Me.RozpocznijToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RozpocznijToolStripMenuItem.Text = "Rozpocznij"
        '
        'ZatrzymajToolStripMenuItem
        '
        Me.ZatrzymajToolStripMenuItem.Name = "ZatrzymajToolStripMenuItem"
        Me.ZatrzymajToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ZatrzymajToolStripMenuItem.Text = "Zatrzymaj"
        '
        'ZresetujCzasToolStripMenuItem
        '
        Me.ZresetujCzasToolStripMenuItem.Name = "ZresetujCzasToolStripMenuItem"
        Me.ZresetujCzasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ZresetujCzasToolStripMenuItem.Text = "Zresetuj czas"
        '
        'GospodarzeToolStripMenuItem
        '
        Me.GospodarzeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NadajNazwęToolStripMenuItem, Me.DodajPunktToolStripMenuItem, Me.OdejmijPunktToolStripMenuItem, Me.UstawieniaDlaGospodarzyToolStripMenuItem})
        Me.GospodarzeToolStripMenuItem.Name = "GospodarzeToolStripMenuItem"
        Me.GospodarzeToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.GospodarzeToolStripMenuItem.Text = "Gospodarze"
        '
        'GościeToolStripMenuItem
        '
        Me.GościeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NadajNazwęToolStripMenuItem1, Me.DodajPunktToolStripMenuItem1, Me.OdejmijPunktToolStripMenuItem1, Me.UstawieniaDlaGościaToolStripMenuItem})
        Me.GościeToolStripMenuItem.Name = "GościeToolStripMenuItem"
        Me.GościeToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.GościeToolStripMenuItem.Text = "Goście"
        '
        'NadajNazwęToolStripMenuItem
        '
        Me.NadajNazwęToolStripMenuItem.Name = "NadajNazwęToolStripMenuItem"
        Me.NadajNazwęToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.NadajNazwęToolStripMenuItem.Text = "Nadaj nazwę"
        '
        'DodajPunktToolStripMenuItem
        '
        Me.DodajPunktToolStripMenuItem.Name = "DodajPunktToolStripMenuItem"
        Me.DodajPunktToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DodajPunktToolStripMenuItem.Text = "Dodaj punkt"
        '
        'OdejmijPunktToolStripMenuItem
        '
        Me.OdejmijPunktToolStripMenuItem.Name = "OdejmijPunktToolStripMenuItem"
        Me.OdejmijPunktToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.OdejmijPunktToolStripMenuItem.Text = "Odejmij punkt"
        '
        'UstawieniaDlaGospodarzyToolStripMenuItem
        '
        Me.UstawieniaDlaGospodarzyToolStripMenuItem.Name = "UstawieniaDlaGospodarzyToolStripMenuItem"
        Me.UstawieniaDlaGospodarzyToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.UstawieniaDlaGospodarzyToolStripMenuItem.Text = "Ustawienia dla gospodarzy"
        '
        'NadajNazwęToolStripMenuItem1
        '
        Me.NadajNazwęToolStripMenuItem1.Name = "NadajNazwęToolStripMenuItem1"
        Me.NadajNazwęToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.NadajNazwęToolStripMenuItem1.Text = "Nadaj nazwę"
        '
        'DodajPunktToolStripMenuItem1
        '
        Me.DodajPunktToolStripMenuItem1.Name = "DodajPunktToolStripMenuItem1"
        Me.DodajPunktToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.DodajPunktToolStripMenuItem1.Text = "Dodaj punkt"
        '
        'OdejmijPunktToolStripMenuItem1
        '
        Me.OdejmijPunktToolStripMenuItem1.Name = "OdejmijPunktToolStripMenuItem1"
        Me.OdejmijPunktToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.OdejmijPunktToolStripMenuItem1.Text = "Odejmij punkt"
        '
        'UstawieniaDlaGościaToolStripMenuItem
        '
        Me.UstawieniaDlaGościaToolStripMenuItem.Name = "UstawieniaDlaGościaToolStripMenuItem"
        Me.UstawieniaDlaGościaToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.UstawieniaDlaGościaToolStripMenuItem.Text = "Ustawienia dla gości"
        '
        'TabelaToolStripMenuItem
        '
        Me.TabelaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ĄToolStripMenuItem, Me.UstawieniaToolStripMenuItem})
        Me.TabelaToolStripMenuItem.Name = "TabelaToolStripMenuItem"
        Me.TabelaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.TabelaToolStripMenuItem.Text = "Tabela"
        '
        'ĄToolStripMenuItem
        '
        Me.ĄToolStripMenuItem.Name = "ĄToolStripMenuItem"
        Me.ĄToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ĄToolStripMenuItem.Text = "Otwórz nową"
        '
        'UstawieniaToolStripMenuItem
        '
        Me.UstawieniaToolStripMenuItem.Name = "UstawieniaToolStripMenuItem"
        Me.UstawieniaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UstawieniaToolStripMenuItem.Text = "Ustawienia tabel"
        '
        'ZrestartujLiczenieToolStripMenuItem
        '
        Me.ZrestartujLiczenieToolStripMenuItem.Name = "ZrestartujLiczenieToolStripMenuItem"
        Me.ZrestartujLiczenieToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ZrestartujLiczenieToolStripMenuItem.Text = "Zrestartuj liczenie"
        '
        'RegEditorToolStripMenuItem
        '
        Me.RegEditorToolStripMenuItem.Name = "RegEditorToolStripMenuItem"
        Me.RegEditorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RegEditorToolStripMenuItem.Text = "RegEditor"
        '
        'WyjścieToolStripMenuItem
        '
        Me.WyjścieToolStripMenuItem.Name = "WyjścieToolStripMenuItem"
        Me.WyjścieToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WyjścieToolStripMenuItem.Text = "Wyjście"
        '
        'UstawCzasToolStripMenuItem
        '
        Me.UstawCzasToolStripMenuItem.Name = "UstawCzasToolStripMenuItem"
        Me.UstawCzasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UstawCzasToolStripMenuItem.Text = "Ustaw czas"
        '
        'LeMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 537)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ListaRzeczy)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.ListaRzeczy
        Me.MaximumSize = New System.Drawing.Size(840, 576)
        Me.MinimumSize = New System.Drawing.Size(840, 576)
        Me.Name = "LeMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LeMenu"
        Me.ListaRzeczy.ResumeLayout(False)
        Me.ListaRzeczy.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As JacksiroKe.MdiTabCtrl.TabControl
    Friend WithEvents ListaRzeczy As MenuStrip
    Friend WithEvents ItemsOpcje As ToolStripMenuItem
    Friend WithEvents ItemsInformacje As ToolStripMenuItem
    Friend WithEvents OProgramieItem As ToolStripMenuItem
    Friend WithEvents CzasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RozpocznijToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZatrzymajToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZresetujCzasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GospodarzeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NadajNazwęToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DodajPunktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OdejmijPunktToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UstawieniaDlaGospodarzyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GościeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NadajNazwęToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DodajPunktToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OdejmijPunktToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UstawieniaDlaGościaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabelaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ĄToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UstawieniaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZrestartujLiczenieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegEditorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WyjścieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UstawCzasToolStripMenuItem As ToolStripMenuItem
End Class
