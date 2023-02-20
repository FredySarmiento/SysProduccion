' moe - Módulo donde se definen las estructuras de datos
Public Class moe_Estructuras
#Region "Gestión"
    Public Class eABAUT
        Private _sCodAut As String '0
        Private _sNomAut As String '1
        Public Property sCodAut As String '0
            Get
                Return _sCodAut
            End Get
            Set(ByVal value As String)
                _sCodAut = value
            End Set
        End Property

        Public Property sNomAut As String '1
            Get
                Return _sNomAut
            End Get
            Set(ByVal value As String)
                _sNomAut = value
            End Set
        End Property
    End Class
    Public Class eABCLC
        Private _sClsCta As String '0
        Private _sNomClsCta As String '1
        Public Property sClsCta As String '0
            Get
                Return _sClsCta
            End Get
            Set(ByVal value As String)
                _sClsCta = value
            End Set
        End Property

        Public Property sNomClsCta As String '1
            Get
                Return _sNomClsCta
            End Get
            Set(ByVal value As String)
                _sNomClsCta = value
            End Set
        End Property
    End Class
    Public Class eABCLD
        Private _sClsDoc As String '0
        Private _sNomClsDoc As String '1
        Public Property sClsDoc As String '0
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property

        Public Property sNomClsDoc As String '1
            Get
                Return _sNomClsDoc
            End Get
            Set(ByVal value As String)
                _sNomClsDoc = value
            End Set
        End Property
    End Class

    Public Class eABEOC
        Private _nId As Long
        Private _sCodEstODC As String '0
        Private _sNomEstODC As String '1
        Private _bRegAci As Boolean
        Private _nNroOrd As Integer

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodEstODC As String '0
            Get
                Return _sCodEstODC
            End Get
            Set(ByVal value As String)
                _sCodEstODC = value
            End Set
        End Property
        Public Property sNomEstODC As String '1
            Get
                Return _sNomEstODC
            End Get
            Set(ByVal value As String)
                _sNomEstODC = value
            End Set
        End Property

        Public Property bRegAci As Boolean '2
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
        Public Property nNroOrd As Integer '2
            Get
                Return _nNroOrd
            End Get
            Set(ByVal value As Integer)
                _nNroOrd = value
            End Set
        End Property

    End Class

    Public Class eABEOP
        Private _nId As Long
        Private _sCodEstODP As String '0
        Private _sNomEstODP As String '1
        Private _bEstSel As Boolean
        Private _bRegAci As Boolean
        Private _nNroOrd As Integer

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodEstODP As String '0
            Get
                Return _sCodEstODP
            End Get
            Set(ByVal value As String)
                _sCodEstODP = value
            End Set
        End Property
        Public Property sNomEstODP As String '1
            Get
                Return _sNomEstODP
            End Get
            Set(ByVal value As String)
                _sNomEstODP = value
            End Set
        End Property

        Public Property bEstSel As Boolean '2
            Get
                Return _bEstSel
            End Get
            Set(ByVal value As Boolean)
                _bEstSel = value
            End Set
        End Property
        Public Property bRegAci As Boolean '2
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
        Public Property nNroOrd As Integer '2
            Get
                Return _nNroOrd
            End Get
            Set(ByVal value As Integer)
                _nNroOrd = value
            End Set
        End Property

    End Class
    Public Class eABEPC
        Private _sCodEstPdoCbe As String '0
        Private _sDesEstPdoCbe As String '1
        Private _bEstSel As Boolean
        Public Property sCodEstPdoCbe As String '0
            Get
                Return _sCodEstPdoCbe
            End Get
            Set(ByVal value As String)
                _sCodEstPdoCbe = value
            End Set
        End Property
        Public Property sDesEstPdoCbe As String '1
            Get
                Return _sDesEstPdoCbe
            End Get
            Set(ByVal value As String)
                _sDesEstPdoCbe = value
            End Set
        End Property
    End Class
    Public Class eABERR
        Private _sCodErr As String '0
        Private _sDesErr As String '1
        Private _sCodClr As String '2
        Private _sTipDes As String '2
        Public Property sCodErr As String '0
            Get
                Return _sCodErr
            End Get
            Set(ByVal value As String)
                _sCodErr = value
            End Set
        End Property
        Public Property sDesErr As String '1
            Get
                Return _sDesErr
            End Get
            Set(ByVal value As String)
                _sDesErr = value
            End Set
        End Property
        Public Property sCodClr As String '2
            Get
                Return _sCodClr
            End Get
            Set(ByVal value As String)
                _sCodClr = value
            End Set
        End Property
        Public Property sTipDes As String '2
            Get
                Return _sTipDes
            End Get
            Set(ByVal value As String)
                _sTipDes = value
            End Set
        End Property

    End Class
    Public Class eABESD
        Private _sEstDoc As String '0
        Private _sNomEstDoc As String '1

        Public Property sEstDoc As String '0
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property sNomEstDoc As String '1
            Get
                Return _sNomEstDoc
            End Get
            Set(ByVal value As String)
                _sNomEstDoc = value
            End Set
        End Property
    End Class
    Public Class eABFMT
        Private _nId As Long '0
        Private _sFmtHH As String '0
        Private _sFmtFec As String '1
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sFmtHH As String '0
            Get
                Return _sFmtHH
            End Get
            Set(ByVal value As String)
                _sFmtHH = value
            End Set
        End Property
        Public Property sFmtFec As String '1
            Get
                Return _sFmtFec
            End Get
            Set(ByVal value As String)
                _sFmtFec = value
            End Set
        End Property
    End Class
    Public Class eABLIM
        Private _sCodLst As String '0
        Private _sDesLst As String '1

        Public Property sCodLst As String '0
            Get
                Return _sCodLst
            End Get
            Set(ByVal value As String)
                _sCodLst = value
            End Set
        End Property
        Public Property sDesLst As String '1
            Get
                Return _sDesLst
            End Get
            Set(ByVal value As String)
                _sDesLst = value
            End Set
        End Property
    End Class
    Public Class eABODP
        Private _sCodDoc As String '0
        Private _sDesDoc As String '1
        Private _bOdpSel As Boolean '2
        Public Property sCodDoc As String '0
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sDesDoc As String '1
            Get
                Return _sDesDoc
            End Get
            Set(ByVal value As String)
                _sDesDoc = value
            End Set
        End Property
        Public Property bOdpSel As Boolean  '2
            Get
                Return _bOdpSel
            End Get
            Set(ByVal value As Boolean)
                _bOdpSel = value
            End Set
        End Property
    End Class
    Public Class eABOPC
        Private _nId As Long
        Private _sCodOpc As String
        Private _sNomOpc As String
        Private _sCodFrm As String
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodOpc As String '1
            Get
                Return _sCodOpc
            End Get
            Set(ByVal value As String)
                _sCodOpc = value
            End Set
        End Property
        Public Property sNomOpc As String '2
            Get
                Return _sNomOpc
            End Get
            Set(ByVal value As String)
                _sNomOpc = value
            End Set
        End Property
        Public Property sCodFrm As String '3
            Get
                Return _sCodFrm
            End Get
            Set(ByVal value As String)
                _sCodFrm = value
            End Set
        End Property
    End Class
    Public Class eABROP
        Private _sTipMov As String '0
        Private _sNomMov As String '1
        Private _bSelxDef As Boolean '2
        Public Property sCodDoc As String '0
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sNomMov As String '1
            Get
                Return _sNomMov
            End Get
            Set(ByVal value As String)
                _sNomMov = value
            End Set
        End Property
        Public Property bSelxDef As Boolean  '2
            Get
                Return _bSelxDef
            End Get
            Set(ByVal value As Boolean)
                _bSelxDef = value
            End Set
        End Property
    End Class
    Public Class eABTGE
        Private _sTipGes As String '0
        Public Property sTipGes As String '0
            Get
                Return _sTipGes
            End Get
            Set(ByVal value As String)
                _sTipGes = value
            End Set
        End Property
    End Class
    Public Class eABTID
        Private _sTipDoc As String '0
        Private _sNomTipDoc As String '1
        Private _bSelxDef As Boolean '2
        Public Property sTipDoc As String '0
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sNomTipDoc As String '1
            Get
                Return _sNomTipDoc
            End Get
            Set(ByVal value As String)
                _sNomTipDoc = value
            End Set
        End Property
        Public Property bSelxDef As Boolean  '2
            Get
                Return _bSelxDef
            End Get
            Set(ByVal value As Boolean)
                _bSelxDef = value
            End Set
        End Property
    End Class
    Public Class eABTIR
        Private _sTipRev As String '0
        Private _sNomTipRev As String '1

        Public Property sTipRev As String '0
            Get
                Return _sTipRev
            End Get
            Set(ByVal value As String)
                _sTipRev = value
            End Set
        End Property
        Public Property sNomTipRev As String '1
            Get
                Return _sNomTipRev
            End Get
            Set(ByVal value As String)
                _sNomTipRev = value
            End Set
        End Property
    End Class
    Public Class eABTIT
        Private _sCodGruTer As String '0
        Private _sNomGruTer As String '1

        Public Property sCodGruTer As String '0
            Get
                Return _sCodGruTer
            End Get
            Set(ByVal value As String)
                _sCodGruTer = value
            End Set
        End Property
        Public Property sNomGruTer As String '1
            Get
                Return _sNomGruTer
            End Get
            Set(ByVal value As String)
                _sNomGruTer = value
            End Set
        End Property
    End Class
    Public Class eABTRT
        Private _sCodTipRegTie As String '0
        Private _sNomTipRegTie As String '1

        Public Property sCodTipRegTie As String '0
            Get
                Return _sCodTipRegTie
            End Get
            Set(ByVal value As String)
                _sCodTipRegTie = value
            End Set
        End Property
        Public Property sNomTipRegTie As String '1
            Get
                Return _sNomTipRegTie
            End Get
            Set(ByVal value As String)
                _sNomTipRegTie = value
            End Set
        End Property
    End Class
    Public Class eABTUS
        Private _sNomUsr As String '0
        Public Property sNomUsr As String '0
            Get
                Return _sNomUsr
            End Get
            Set(ByVal value As String)
                _sNomUsr = value
            End Set
        End Property
    End Class
    Public Class eACBDE
        Private _nId As Long '0
        Private _sCodCia As String '1
        Private _bCiaSel As Boolean '2
        Private _sNomBD As String '3
        Private _sNomBDCnf As String '4
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCia As String '1
            Get
                Return _sCodCia
            End Get
            Set(ByVal value As String)
                _sCodCia = value
            End Set
        End Property
        Public Property bCiaSel As Boolean '2
            Get
                Return _bCiaSel
            End Get
            Set(ByVal value As Boolean)
                _bCiaSel = value
            End Set
        End Property
        Public Property sNomBD As String '3
            Get
                Return _sNomBD
            End Get
            Set(ByVal value As String)
                _sNomBD = value
            End Set
        End Property
        Public Property sNomBDCnf As String '3
            Get
                Return _sNomBDCnf
            End Get
            Set(ByVal value As String)
                _sNomBDCnf = value
            End Set
        End Property
    End Class
    Public Class eACDEM
        Private _nId As Long '0
        Private _sNomCia As String '1
        Private _sDirCia As String '2
        Private _sCiuCia As String '3
        Private _sDepCia As String '4
        Private _sPaiCia As String '5
        Private _sRepLeg As String '6
        Private _sEmlCia As String '7
        Private _sTel1Cia As String '8
        Private _sTel2Cia As String '9
        Private _sFaxCia As String '10
        Private _sNitCia As String '11
        Private _sDigVer As String '12
        Private _nAnoSdoIniInv As Integer '13
        Private _bInvPte As Boolean '14
        Private _sTipInv As String '15
        Private _bCosXBod As Boolean '16
        Private _bMovSinCos As Boolean '17
        Private _sCodCia As String '18

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sNomCia As String '1
            Get
                Return _sNomCia
            End Get
            Set(ByVal value As String)
                _sNomCia = value
            End Set
        End Property
        Public Property sDirCia As String '2
            Get
                Return _sDirCia
            End Get
            Set(ByVal value As String)
                _sDirCia = value
            End Set
        End Property
        Public Property sCiuCia As String '3
            Get
                Return _sCiuCia
            End Get
            Set(ByVal value As String)
                _sCiuCia = value
            End Set
        End Property
        Public Property sDepCia As String '4
            Get
                Return _sDepCia
            End Get
            Set(ByVal value As String)
                _sDepCia = value
            End Set
        End Property
        Public Property sPaiCia As String '5
            Get
                Return _sPaiCia
            End Get
            Set(ByVal value As String)
                _sPaiCia = value
            End Set
        End Property
        Public Property sRepLeg As String '6
            Get
                Return _sRepLeg
            End Get
            Set(ByVal value As String)
                _sRepLeg = value
            End Set
        End Property
        Public Property sEmlCia As String '7
            Get
                Return _sEmlCia
            End Get
            Set(ByVal value As String)
                _sEmlCia = value
            End Set
        End Property
        Public Property sTel1Cia As String '8
            Get
                Return _sTel1Cia
            End Get
            Set(ByVal value As String)
                _sTel1Cia = value
            End Set
        End Property
        Public Property sTel2Cia As String '9
            Get
                Return _sTel2Cia
            End Get
            Set(ByVal value As String)
                _sTel2Cia = value
            End Set
        End Property
        Public Property sFaxCia As String '10
            Get
                Return _sFaxCia
            End Get
            Set(ByVal value As String)
                _sFaxCia = value
            End Set
        End Property
        Public Property sNitCia As String '11
            Get
                Return _sNitCia
            End Get
            Set(ByVal value As String)
                _sNitCia = value
            End Set
        End Property
        Public Property sDigVer As String '12
            Get
                Return _sDigVer
            End Get
            Set(ByVal value As String)
                _sDigVer = value
            End Set
        End Property
        Public Property nAnoSdoIniInv As Integer '13
            Get
                Return _nAnoSdoIniInv
            End Get
            Set(ByVal value As Integer)
                _nAnoSdoIniInv = value
            End Set
        End Property
        Public Property bInvPte As Boolean '14
            Get
                Return _bInvPte
            End Get
            Set(ByVal value As Boolean)
                _bInvPte = value
            End Set
        End Property
        Public Property sTipInv As String '15
            Get
                Return _sTipInv
            End Get
            Set(ByVal value As String)
                _sTipInv = value
            End Set
        End Property
        Public Property bCosXBod As Boolean '16
            Get
                Return _bCosXBod
            End Get
            Set(ByVal value As Boolean)
                _bCosXBod = value
            End Set
        End Property
        Public Property bMovSinCos As Boolean '17
            Get
                Return _bMovSinCos
            End Get
            Set(ByVal value As Boolean)
                _bMovSinCos = value
            End Set
        End Property
        Public Property sCodCia As String '18
            Get
                Return _sCodCia
            End Get
            Set(ByVal value As String)
                _sCodCia = value
            End Set
        End Property
    End Class
    Public Class eACPAG
        Private _nId As Long '0
        Private _sCodCia As String '1
        Private _sCodUsr As String
        Private _bLmtCre As Boolean
        Private _sCndPagxDefCli As String
        Private _sMetPagxDefCli As String '5
        Private _sCndPagxDefPro As String
        Private _sMetPagxDefPro As String
        Private _sClrFrm As String
        Private _sTipFont As String
        Private _nTamFont As Double '10
        Private _sForFec As String
        Private _sForHor As String
        Private _nNroDecPre As Integer
        Private _nNroDecCan As Integer
        Private _nNroDecPor As Integer '15
        Private _sCodAlmXDef As String
        Private _sCriCtaCtb As String
        Private _bVisItmIna As Boolean
        Private _sRutXls As String
        Private _sTipRegTie As String
        Private _sCodAlmCom As String
        Private _bPrnODPPla As Boolean
        Private _nPorGto As Double '
        Private _nPorIto As Double '
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCia As String '1
            Get
                Return _sCodCia
            End Get
            Set(ByVal value As String)
                _sCodCia = value
            End Set
        End Property
        Public Property sCodUsr As String
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property bLmtCre As Boolean
            Get
                Return _bLmtCre
            End Get
            Set(ByVal value As Boolean)
                _bLmtCre = value
            End Set
        End Property
        Public Property sCndPagxDefCli As String
            Get
                Return _sCndPagxDefCli
            End Get
            Set(ByVal value As String)
                _sCndPagxDefCli = value
            End Set
        End Property
        Public Property sMetPagxDefCli As String '5
            Get
                Return _sMetPagxDefCli
            End Get
            Set(ByVal value As String)
                _sMetPagxDefCli = value
            End Set
        End Property
        Public Property sCndPagxDefPro As String
            Get
                Return _sCndPagxDefPro
            End Get
            Set(ByVal value As String)
                _sCndPagxDefPro = value
            End Set
        End Property
        Public Property sMetPagxDefPro As String
            Get
                Return _sMetPagxDefPro
            End Get
            Set(ByVal value As String)
                _sMetPagxDefPro = value
            End Set
        End Property
        Public Property sClrFrm As String
            Get
                Return _sClrFrm
            End Get
            Set(ByVal value As String)
                _sClrFrm = value
            End Set
        End Property
        Public Property sTipFont As String
            Get
                Return _sTipFont
            End Get
            Set(ByVal value As String)
                _sTipFont = value
            End Set
        End Property
        Public Property nTamFont As Double '10
            Get
                Return _nTamFont
            End Get
            Set(ByVal value As Double)
                _nTamFont = value
            End Set
        End Property
        Public Property sForFec As String
            Get
                Return _sForFec
            End Get
            Set(ByVal value As String)
                _sForFec = value
            End Set
        End Property
        Public Property sForHor As String
            Get
                Return _sForHor
            End Get
            Set(ByVal value As String)
                _sForHor = value
            End Set
        End Property
        Public Property nNroDecPre As Integer
            Get
                Return _nNroDecPre
            End Get
            Set(ByVal value As Integer)
                _nNroDecPre = value
            End Set
        End Property
        Public Property nNroDecCan As Integer
            Get
                Return _nNroDecCan
            End Get
            Set(ByVal value As Integer)
                _nNroDecCan = value
            End Set
        End Property
        Public Property nNroDecPor As Integer '15
            Get
                Return _nNroDecPor
            End Get
            Set(ByVal value As Integer)
                _nNroDecPor = value
            End Set
        End Property
        Public Property sCodAlmXDef As String
            Get
                Return _sCodAlmXDef
            End Get
            Set(ByVal value As String)
                _sCodAlmXDef = value
            End Set
        End Property
        Public Property sCriCtaCtb As String
            Get
                Return _sCriCtaCtb
            End Get
            Set(ByVal value As String)
                _sCriCtaCtb = value
            End Set
        End Property
        Public Property bVisItmIna As Boolean
            Get
                Return _bVisItmIna
            End Get
            Set(ByVal value As Boolean)
                _bVisItmIna = value
            End Set
        End Property
        Public Property sRutXls As String
            Get
                Return _sRutXls
            End Get
            Set(ByVal value As String)
                _sRutXls = value
            End Set
        End Property
        Public Property sTipRegTie As String '20
            Get
                Return _sTipRegTie
            End Get
            Set(ByVal value As String)
                _sTipRegTie = value
            End Set
        End Property
        Public Property sCodAlmCom As String
            Get
                Return _sCodAlmCom
            End Get
            Set(ByVal value As String)
                _sCodAlmCom = value
            End Set
        End Property
        Public Property bPrnODPPla As Boolean
            Get
                Return _bPrnODPPla
            End Get
            Set(ByVal value As Boolean)
                _bPrnODPPla = value
            End Set
        End Property
        Public Property nPorGto As Double '10
            Get
                Return _nPorGto
            End Get
            Set(ByVal value As Double)
                _nPorGto = value
            End Set
        End Property
        Public Property nPorIto As Double '
            Get
                Return _nPorIto
            End Get
            Set(ByVal value As Double)
                _nPorIto = value
            End Set
        End Property
    End Class
    Public Class eACUNI
        Private _sCodUni As String
        Private _sNomUni As String
        Private _sCodUniBas As String
        Private _nUniBas As Double
        Public Property sCodUni As String '0
            Get
                Return _sCodUni
            End Get
            Set(ByVal value As String)
                _sCodUni = value
            End Set
        End Property
        Public Property sNomUni As String
            Get
                Return _sNomUni
            End Get
            Set(ByVal value As String)
                _sNomUni = value
            End Set
        End Property
        Public Property sCodUniBas As String
            Get
                Return _sCodUniBas
            End Get
            Set(ByVal value As String)
                _sCodUniBas = value
            End Set
        End Property
        Public Property nUniBas As Double '4
            Get
                Return _nUniBas
            End Get
            Set(ByVal value As Double)
                _nUniBas = value
            End Set
        End Property
    End Class
    Public Class eAPDGV
        Private _nId As Long '0
        Private _sCodFrm As String '1
        Private _sCodDgv As String '2
        Private _nColOri As Integer '3
        Private _nNroCol As Integer '4
        Private _sTitCol As String '5
        Private _sTipCol As String '6'
        Private _bColxDef As Boolean '7
        Private _bVisible As Boolean '8
        Private _bReadOnly As Boolean '9
        Private _sNomCmp As String '10
        Private _nTamCmp As Integer '11

        Private _bColPor As Boolean '10
        Private _nColNom As Integer '11
        Private _nColVlr As Integer '12
        Private _sNomDat As String '13
        Private _bDatReq As Boolean '14
        Private _sRglVdaDat As String '15
        Private _sCodErrDat As String '16
        Private _sNomTblVda As String '17
        Private _bVdaEOF As Boolean '18
        Private _sRglVdaEOF As String '19
        Private _sCodErrEOF As String '20
        Private _sDesOpe As String '21
        Private _nColRes As Integer '22
        Private _sCodErrOpe As String '23
        Private _nColVda As Integer '24
        Private _sRglVdaCol As String '25
        Private _sCodErrCol As String '26
        Private _sDatBas As String '27
        Private _bColTot As Boolean '28
        Private _bGQLst As Boolean '29
        Private _sCodErrEOF1 As String '30
        Private _nColCtaInv As Integer '31
        Private _nColCosVta As Integer '32 
        Private _sTblOriDat As String '33
        Private _nColDocBas As Integer '34

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodFrm As String '1
            Get
                Return _sCodFrm
            End Get
            Set(ByVal value As String)
                _sCodFrm = value
            End Set
        End Property
        Public Property sCodDgv As String '2
            Get
                Return _sCodDgv
            End Get
            Set(ByVal value As String)
                _sCodDgv = value
            End Set
        End Property
        Public Property nColOri As Integer '3
            Get
                Return _nColOri
            End Get
            Set(ByVal value As Integer)
                _nColOri = value
            End Set
        End Property
        Public Property nNroCol As Integer '4
            Get
                Return _nNroCol
            End Get
            Set(ByVal value As Integer)
                _nNroCol = value
            End Set
        End Property
        Public Property sTitCol As String '5
            Get
                Return _sTitCol
            End Get
            Set(ByVal value As String)
                _sTitCol = value
            End Set
        End Property
        Public Property sTipCol As String '6
            Get
                Return _sTipCol
            End Get
            Set(ByVal value As String)
                _sTipCol = value
            End Set
        End Property
        Public Property bColxDef As Boolean '7
            Get
                Return _bColxDef
            End Get
            Set(ByVal value As Boolean)
                _bColxDef = value
            End Set
        End Property
        Public Property bVisible As Boolean '8
            Get
                Return _bVisible
            End Get
            Set(ByVal value As Boolean)
                _bVisible = value
            End Set
        End Property
        Public Property bReadOnly As Boolean '9
            Get
                Return _bReadOnly
            End Get
            Set(ByVal value As Boolean)
                _bReadOnly = value
            End Set
        End Property
        Public Property sNomCmp As String '10
            Get
                Return _sNomCmp
            End Get
            Set(ByVal value As String)
                _sNomCmp = value
            End Set
        End Property
        Public Property nTamCmp As Integer '11
            Get
                Return _nTamCmp
            End Get
            Set(ByVal value As Integer)
                _nTamCmp = value
            End Set
        End Property



        Public Property bColPor As Boolean '10
            Get
                Return _bColPor
            End Get
            Set(ByVal value As Boolean)
                _bColPor = value
            End Set
        End Property
        Public Property nColNom As Integer '11
            Get
                Return _nColNom
            End Get
            Set(ByVal value As Integer)
                _nColNom = value
            End Set
        End Property
        Public Property nColVlr As Integer '12
            Get
                Return _nColVlr
            End Get
            Set(ByVal value As Integer)
                _nColVlr = value
            End Set
        End Property
        Public Property sNomDat As String '13
            Get
                Return _sNomDat
            End Get
            Set(ByVal value As String)
                _sNomDat = value
            End Set
        End Property
        Public Property bDatReq As Boolean '14
            Get
                Return _bDatReq
            End Get
            Set(ByVal value As Boolean)
                _bDatReq = value
            End Set
        End Property
        Public Property sRglVdaDat As String '15
            Get
                Return _sRglVdaDat
            End Get
            Set(ByVal value As String)
                _sRglVdaDat = value
            End Set
        End Property
        Public Property sCodErrDat As String '16
            Get
                Return _sCodErrDat
            End Get
            Set(ByVal value As String)
                _sCodErrDat = value
            End Set
        End Property
        Public Property sNomTblVda As String '17
            Get
                Return _sNomTblVda
            End Get
            Set(ByVal value As String)
                _sNomTblVda = value
            End Set
        End Property
        Public Property bVdaEOF As Boolean  '18
            Get
                Return _bVdaEOF
            End Get
            Set(ByVal value As Boolean)
                _bVdaEOF = value
            End Set
        End Property
        Public Property sRglVdaEOF As String '19
            Get
                Return _sRglVdaEOF
            End Get
            Set(ByVal value As String)
                _sRglVdaEOF = value
            End Set
        End Property
        Public Property sCodErrEOF As String '20
            Get
                Return _sCodErrEOF
            End Get
            Set(ByVal value As String)
                _sCodErrEOF = value
            End Set
        End Property
        Public Property sDesOpe As String '21
            Get
                Return _sDesOpe
            End Get
            Set(ByVal value As String)
                _sDesOpe = value
            End Set
        End Property
        Public Property nColRes As Integer '22
            Get
                Return _nColRes
            End Get
            Set(ByVal value As Integer)
                _nColRes = value
            End Set
        End Property
        Public Property sCodErrOpe As String '23
            Get
                Return _sCodErrOpe
            End Get
            Set(ByVal value As String)
                _sCodErrOpe = value
            End Set
        End Property
        Public Property nColVda As Integer '24
            Get
                Return _nColVda
            End Get
            Set(ByVal value As Integer)
                _nColVda = value
            End Set
        End Property
        Public Property sRglVdaCol As String '25
            Get
                Return _sRglVdaCol
            End Get
            Set(ByVal value As String)
                _sRglVdaCol = value
            End Set
        End Property
        Public Property sCodErrCol As String '26
            Get
                Return _sCodErrCol
            End Get
            Set(ByVal value As String)
                _sCodErrCol = value
            End Set
        End Property
        Public Property sDatBas As String '27
            Get
                Return _sDatBas
            End Get
            Set(ByVal value As String)
                _sDatBas = value
            End Set
        End Property
        Public Property bColTot As Boolean '28
            Get
                Return _bColTot
            End Get
            Set(ByVal value As Boolean)
                _bColTot = value
            End Set
        End Property
        Public Property bGQLst As Boolean '29
            Get
                Return _bGQLst
            End Get
            Set(ByVal value As Boolean)
                _bGQLst = value
            End Set
        End Property
        Public Property sCodErrEOF1 As String '30
            Get
                Return _sCodErrEOF1
            End Get
            Set(ByVal value As String)
                _sCodErrEOF1 = value
            End Set
        End Property
        Public Property nColCtaInv As Integer '31
            Get
                Return _nColCtaInv
            End Get
            Set(ByVal value As Integer)
                _nColCtaInv = value
            End Set
        End Property
        Public Property nColCosVta As Integer '32
            Get
                Return _nColCosVta
            End Get
            Set(ByVal value As Integer)
                _nColCosVta = value
            End Set
        End Property
        Public Property sTblOriDat As String '33
            Get
                Return _sTblOriDat
            End Get
            Set(ByVal value As String)
                _sTblOriDat = value
            End Set
        End Property
        Public Property nColDocBas As Integer '34
            Get
                Return _nColDocBas
            End Get
            Set(ByVal value As Integer)
                _nColDocBas = value
            End Set
        End Property

    End Class
    Public Class eAPQDG
        Private _nId As Long '0
        Private _sCodStr As String '1
        Private _nColOri As Integer '2
        Private _nNroCol As Integer '3
        Private _sTitCol As String '4
        Private _sTipCol As String '5
        Private _bColxDef As Boolean '6
        Private _bVisible As Boolean '7
        Private _bReadOnly As Boolean '8
        Private _sNomCmp As String '9
        Private _nTamCmp As Integer '10
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodStr As String '1
            Get
                Return _sCodStr
            End Get
            Set(ByVal value As String)
                _sCodStr = value
            End Set
        End Property
        Public Property nColOri As Integer '2
            Get
                Return _nColOri
            End Get
            Set(ByVal value As Integer)
                _nColOri = value
            End Set
        End Property
        Public Property nNroCol As Integer '3
            Get
                Return _nNroCol
            End Get
            Set(ByVal value As Integer)
                _nNroCol = value
            End Set
        End Property
        Public Property sTitCol As String '4
            Get
                Return _sTitCol
            End Get
            Set(ByVal value As String)
                _sTitCol = value
            End Set
        End Property
        Public Property sTipCol As String '5
            Get
                Return _sTipCol
            End Get
            Set(ByVal value As String)
                _sTipCol = value
            End Set
        End Property
        Public Property bColxDef As Boolean '6
            Get
                Return _bColxDef
            End Get
            Set(ByVal value As Boolean)
                _bColxDef = value
            End Set
        End Property
        Public Property bVisible As Boolean '7
            Get
                Return _bVisible
            End Get
            Set(ByVal value As Boolean)
                _bVisible = value
            End Set
        End Property
        Public Property bReadOnly As Boolean '8
            Get
                Return _bReadOnly
            End Get
            Set(ByVal value As Boolean)
                _bReadOnly = value
            End Set
        End Property
        Public Property sNomCmp As String '9
            Get
                Return _sNomCmp
            End Get
            Set(ByVal value As String)
                _sNomCmp = value
            End Set
        End Property
        Public Property nTamCmp As Integer '10
            Get
                Return _nTamCmp
            End Get
            Set(ByVal value As Integer)
                _nTamCmp = value
            End Set
        End Property
    End Class
    Public Class eAPRDG
        Private _nId As Long '0
        Private _sCodRpt As String '1
        Private _nColOri As Integer '2
        Private _nNroCol As Integer '3
        Private _sTitCol As String '4
        Private _sTipCol As String '5
        Private _bVisible As Boolean '7
        Private _sNomCmp As String '9
        Private _nTamCmp As Integer '10
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodRpt As String '1
            Get
                Return _sCodRpt
            End Get
            Set(ByVal value As String)
                _sCodRpt = value
            End Set
        End Property
        Public Property nColOri As Integer '2
            Get
                Return _nColOri
            End Get
            Set(ByVal value As Integer)
                _nColOri = value
            End Set
        End Property
        Public Property nNroCol As Integer '3
            Get
                Return _nNroCol
            End Get
            Set(ByVal value As Integer)
                _nNroCol = value
            End Set
        End Property
        Public Property sTitCol As String '4
            Get
                Return _sTitCol
            End Get
            Set(ByVal value As String)
                _sTitCol = value
            End Set
        End Property
        Public Property sTipCol As String '5
            Get
                Return _sTipCol
            End Get
            Set(ByVal value As String)
                _sTipCol = value
            End Set
        End Property
        Public Property bVisible As Boolean '6
            Get
                Return _bVisible
            End Get
            Set(ByVal value As Boolean)
                _bVisible = value
            End Set
        End Property

        Public Property sNomCmp As String '7
            Get
                Return _sNomCmp
            End Get
            Set(ByVal value As String)
                _sNomCmp = value
            End Set
        End Property
        Public Property nTamCmp As Integer '10
            Get
                Return _nTamCmp
            End Get
            Set(ByVal value As Integer)
                _nTamCmp = value
            End Set
        End Property
    End Class
    Public Class eAPEND
        Private _nId As Long '0
        Private _sCodDoc As String
        Private _sCodSer As String
        Private _sNomDoc As String
        Private _sTipMov As String
        Private _nNroIni As Long '5
        Private _nNroSig As Long
        Private _nNroFin As Long
        Private _sClsDoc As String '8
        Private _sCodTra As String '9
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sCodSer As String
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sNomDoc As String
            Get
                Return _sNomDoc
            End Get
            Set(ByVal value As String)
                _sNomDoc = value
            End Set
        End Property
        Public Property sTipMov As String
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property nNroIni As Long '5
            Get
                Return _nNroIni
            End Get
            Set(ByVal value As Long)
                _nNroIni = value
            End Set
        End Property
        Public Property nNroSig As Long
            Get
                Return _nNroSig
            End Get
            Set(ByVal value As Long)
                _nNroSig = value
            End Set
        End Property
        Public Property nNroFin As Long
            Get
                Return _nNroFin
            End Get
            Set(ByVal value As Long)
                _nNroFin = value
            End Set
        End Property
        Public Property sClsDoc As String '8
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCodTra As String '8
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
    End Class
    Public Class eAPFRM
        Private _nId As Long '0
        Private _sCodFrm As String
        Private _sNomFrm As String

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodFrm As String
            Get
                Return _sCodFrm
            End Get
            Set(ByVal value As String)
                _sCodFrm = value
            End Set
        End Property
        Public Property sNomFrm As String
            Get
                Return _sNomFrm
            End Get
            Set(ByVal value As String)
                _sNomFrm = value
            End Set
        End Property
    End Class
    Public Class eAPLND1
        Private _nId As Long '0
        Private _sCodDoc As String
        Private _sCodSer As String
        Private _nNroIni As Long
        Private _nNroSig As Long
        Private _nNroFin As Long '5
        Private _sCodTra As String '6
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sCodSer As String
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property nNroIni As Long
            Get
                Return _nNroIni
            End Get
            Set(ByVal value As Long)
                _nNroIni = value
            End Set
        End Property
        Public Property nNroSig As Long
            Get
                Return _nNroSig
            End Get
            Set(ByVal value As Long)
                _nNroSig = value
            End Set
        End Property
        Public Property nNroFin As Long '5
            Get
                Return _nNroFin
            End Get
            Set(ByVal value As Long)
                _nNroFin = value
            End Set
        End Property
        Public Property sCodTra As String '6
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
    End Class
    Public Class eAPGQLst
        Private _nId As Long '0
        Private _sCodStr As String
        Private _sNomStr As String

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodStr As String
            Get
                Return _sCodStr
            End Get
            Set(ByVal value As String)
                _sCodStr = value
            End Set
        End Property
        Public Property sNomStr As String
            Get
                Return _sNomStr
            End Get
            Set(ByVal value As String)
                _sNomStr = value
            End Set
        End Property
    End Class
    Public Class eATALM
        Private _nId As Long '0
        Private _sCodAlm As String '1
        Private _sNomAlm As String '2
        Private _sUbiAlm As String '3
        Private _sCtaInv As String '4
        Private _sCtaCosVta As String '5
        Private _sCtaTrs As String '6
        Private _sCtaIng As String '7
        Private _sCtaDevVta As String ' 8
        Private _sCtaVrc As String '9
        Private _sCtaGto As String '10
        Private _sCtaDot As String '11
        Private _sCtaDifPre As String '12
        Private _sCtaRev As String '13
        Private _sCtaAumInv As String '14
        Private _sCtaRedInv As String '15
        Private _sCtaCom As String '16
        Private _sCtaDevCom As String '17
        Private _sCtaWIP As String '18
        Private _bSelxDef As Boolean
        Private _bRegAci As Boolean '20


        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodAlm As String '1
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property sNomAlm As String '2
            Get
                Return _sNomAlm
            End Get
            Set(ByVal value As String)
                _sNomAlm = value
            End Set
        End Property
        Public Property sUbiAlm As String '3
            Get
                Return _sUbiAlm
            End Get
            Set(ByVal value As String)
                _sUbiAlm = value
            End Set
        End Property
        Public Property sCtaInv As String '4
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
        Public Property sCtaCosVta As String '5
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property sCtaTrs As String
            Get
                Return _sCtaTrs
            End Get
            Set(ByVal value As String)
                _sCtaTrs = value
            End Set
        End Property
        Public Property sCtaIng As String
            Get
                Return _sCtaIng
            End Get
            Set(ByVal value As String)
                _sCtaIng = value
            End Set
        End Property
        Public Property sCtaDevVta As String
            Get
                Return _sCtaDevVta
            End Get
            Set(ByVal value As String)
                _sCtaDevVta = value
            End Set
        End Property
        Public Property sCtaVrc As String
            Get
                Return _sCtaVrc
            End Get
            Set(ByVal value As String)
                _sCtaVrc = value
            End Set
        End Property
        Public Property sCtaGto As String '10
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
            End Set
        End Property
        Public Property sCtaDot As String
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaRev As String
            Get
                Return _sCtaRev
            End Get
            Set(ByVal value As String)
                _sCtaRev = value
            End Set
        End Property
        Public Property sCtaAumInv As String
            Get
                Return _sCtaAumInv
            End Get
            Set(ByVal value As String)
                _sCtaAumInv = value
            End Set
        End Property
        Public Property sCtaRedInv As String '15
            Get
                Return _sCtaRedInv
            End Get
            Set(ByVal value As String)
                _sCtaRedInv = value
            End Set
        End Property
        Public Property sCtaCom As String
            Get
                Return _sCtaCom
            End Get
            Set(ByVal value As String)
                _sCtaCom = value
            End Set
        End Property
        Public Property sCtaDevCom As String
            Get
                Return _sCtaDevCom
            End Get
            Set(ByVal value As String)
                _sCtaDevCom = value
            End Set
        End Property
        Public Property sCtaWIP As String '18
            Get
                Return _sCtaWIP
            End Get
            Set(ByVal value As String)
                _sCtaWIP = value
            End Set
        End Property
        Public Property bSelxDef As Boolean '18
            Get
                Return _bSelxDef
            End Get
            Set(ByVal value As Boolean)
                _bSelxDef = value
            End Set
        End Property
        Public Property bRegAci As Boolean '18
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property

    End Class
    Public Class eATANA
        Private _nId As Long '0
        Private _sCodAna As String '1
        Private _sNomAna As String '2
        Private _sCodTipAna As String '3
        Private _bRegAci As Boolean
        'Campos externos
        Private _sNomTipAna As String '4
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodAna As String '1
            Get
                Return _sCodAna
            End Get
            Set(ByVal value As String)
                _sCodAna = value
            End Set
        End Property
        Public Property sNomAna As String '2
            Get
                Return _sNomAna
            End Get
            Set(ByVal value As String)
                _sNomAna = value
            End Set
        End Property
        Public Property sCodTipAna As String '3
            Get
                Return _sCodTipAna
            End Get
            Set(ByVal value As String)
                _sCodTipAna = value
            End Set
        End Property
        Public Property bRegAci As Boolean '39
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
        Public Property sNomTipAna As String '4
            Get
                Return _sNomTipAna
            End Get
            Set(ByVal value As String)
                _sNomTipAna = value
            End Set
        End Property
    End Class
    Public Class eATASI
        Private _nId As Long '0
        Private _nAnoSdoIni As Integer '1
        Private _sNomTblEnc As String '2
        Private _sNomTblDet As String '3
        Private _sNomTblEncSdoIni As String '4
        Private _sNomTblDetSdoIni As String '5
        Private _dFecIniAno As Date '6
        Private _sEstPdo As String '7
        Private _bRegAci As Boolean '8

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property nAnoSdoIni As Integer '1
            Get
                Return _nAnoSdoIni
            End Get
            Set(ByVal value As Integer)
                _nAnoSdoIni = value
            End Set
        End Property
        Public Property sNomTblEnc As String '2
            Get
                Return _sNomTblEnc
            End Get
            Set(ByVal value As String)
                _sNomTblEnc = value
            End Set
        End Property
        Public Property sNomTblDet As String '3
            Get
                Return _sNomTblDet
            End Get
            Set(ByVal value As String)
                _sNomTblDet = value
            End Set
        End Property
        Public Property sNomTblEncSdoIni As String '4
            Get
                Return _sNomTblEncSdoIni
            End Get
            Set(ByVal value As String)
                _sNomTblEncSdoIni = value
            End Set
        End Property
        Public Property sNomTblDetSdoIni As String '5
            Get
                Return _sNomTblDetSdoIni
            End Get
            Set(ByVal value As String)
                _sNomTblDetSdoIni = value
            End Set
        End Property
        Public Property dFecIniAno As Date '6
            Get
                Return _dFecIniAno
            End Get
            Set(ByVal value As Date)
                _dFecIniAno = value
            End Set
        End Property
        Public Property sEstPdo As String '7
            Get
                Return _sEstPdo
            End Get
            Set(ByVal value As String)
                _sEstPdo = value
            End Set
        End Property
        Public Property bRegAci As Boolean '8
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
     
    End Class
    Public Class eATAUT
        Private _nId As Long
        Private _sCodUsr As String
        Private _sCodFrm As String
        Private _sNomOpc As String
        Private _sCodAut As String
        Private _sNomAut As String
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodUsr As String '1
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sCodFrm As String '2
            Get
                Return _sCodFrm
            End Get
            Set(ByVal value As String)
                _sCodFrm = value
            End Set
        End Property
        Public Property sNomOpc As String
            Get
                Return _sNomOpc
            End Get
            Set(ByVal value As String)
                _sNomOpc = value
            End Set
        End Property
        Public Property sCodAut As String '3
            Get
                Return _sCodAut
            End Get
            Set(ByVal value As String)
                _sCodAut = value
            End Set
        End Property
        Public Property sNomAut As String
            Get
                Return _sNomAut
            End Get
            Set(ByVal value As String)
                _sNomAut = value
            End Set
        End Property
    End Class
    Public Class eATCCO
        Private _nId As Long '0
        Private _sCodCco As String '1
        Private _sNomCco As String '2
        Private _bRegAci As Boolean

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCco As String '1
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property sNomCco As String '2
            Get
                Return _sNomCco
            End Get
            Set(ByVal value As String)
                _sNomCco = value
            End Set
        End Property
        Public Property bRegAci As Boolean '
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATCIF
        Private _nId As Long '0
        Private _sCodCIF As String
        Private _sNomCIF As String
        Private _sCodCtr As String
        Private _nTasCIF As Double
        Private _nVlrCIF As Double '5
        Private _nVlrCIFPpo As Double
        Private _nBasCIFPpo As Double
        Private _nVlrCIFRea As Double '8
        Private _bRegAci As Boolean
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCIF As String '1
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property sNomCIF As String
            Get
                Return _sNomCIF
            End Get
            Set(ByVal value As String)
                _sNomCIF = value
            End Set
        End Property
        Public Property sCodCtr As String
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nTasCIF As Double
            Get
                Return _nTasCIF
            End Get
            Set(ByVal value As Double)
                _nTasCIF = value
            End Set
        End Property
        Public Property nVlrCIF As Double '5
            Get
                Return _nVlrCIF
            End Get
            Set(ByVal value As Double)
                _nVlrCIF = value
            End Set
        End Property
        Public Property nVlrCIFPpo As Double
            Get
                Return _nVlrCIFPpo
            End Get
            Set(ByVal value As Double)
                _nVlrCIFPpo = value
            End Set
        End Property
        Public Property nBasCIFPpo As Double
            Get
                Return _nBasCIFPpo
            End Get
            Set(ByVal value As Double)
                _nBasCIFPpo = value
            End Set
        End Property
        Public Property nVlrCIFRea As Double '8
            Get
                Return _nVlrCIFRea
            End Get
            Set(ByVal value As Double)
                _nVlrCIFRea = value
            End Set
        End Property
        Public Property bRegAci As Boolean
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property

    End Class
    Public Class eATCTR
        Private _nId As Long '0
        Private _sCodCtr As String '1
        Private _sNomCtr As String '2
        Private _sCodCco As String '3
        Private _nCosMODFij As Double '4
        Private _nCosMODVar As Double '5
        Private _nCosHorCpr As Double '6
        Private _nScoVar As Double '7
        Private _nCosHorVar As Double '8
        Private _nCosTotMOD As Double '9
        Private _nUniTieOpe As Double '10
        Private _nPreUni As Double '11
        Private _bRegAci As Boolean
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCtr As String '1
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property sNomCtr As String '2
            Get
                Return _sNomCtr
            End Get
            Set(ByVal value As String)
                _sNomCtr = value
            End Set
        End Property
        Public Property sCodCco As String '3
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property nCosMODFij As Double '4
            Get
                Return _nCosMODFij
            End Get
            Set(ByVal value As Double)
                _nCosMODFij = value
            End Set
        End Property
        Public Property nCosMODVar As Double '5
            Get
                Return _nCosMODVar
            End Get
            Set(ByVal value As Double)
                _nCosMODVar = value
            End Set
        End Property
        Public Property nCosHorCpr As Double '6
            Get
                Return _nCosHorCpr
            End Get
            Set(ByVal value As Double)
                _nCosHorCpr = value
            End Set
        End Property
        Public Property nScoVar As Double '7
            Get
                Return _nScoVar
            End Get
            Set(ByVal value As Double)
                _nScoVar = value
            End Set
        End Property
        Public Property nCosHorVar As Double '8
            Get
                Return _nCosHorVar
            End Get
            Set(ByVal value As Double)
                _nCosHorVar = value
            End Set
        End Property

        Public Property nCosTotMOD As Double '9
            Get
                Return _nCosTotMOD
            End Get
            Set(ByVal value As Double)
                _nCosTotMOD = value
            End Set
        End Property
        Public Property nUniTieOpe As Double '10
            Get
                Return _nUniTieOpe
            End Get
            Set(ByVal value As Double)
                _nUniTieOpe = value
            End Set
        End Property
        Public Property nPreUni As Double '11
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property bRegAci As Boolean
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATGRI
        Private _nId As Long '0
        Private _sCodGrp As String '1
        Private _sNomGrp As String '2
        Private _sCtaInv As String '3
        Private _sCtaCosVta As String '4
        Private _sCtaTrs As String '5
        Private _sCtaIng As String '6
        Private _sCtaDevVta As String ' 7
        Private _sCtaVrc As String '8
        Private _sCtaGto As String '9
        Private _sCtaDot As String '10
        Private _sCtaDifPre As String '11
        Private _sCtaRev As String '12
        Private _sCtaAumInv As String '13
        Private _sCtaRedInv As String '14
        Private _sCtaCom As String '15
        Private _sCtaDevCom As String '16
        Private _sCtaWIP As String '17
        Private _sSysInv As String
        Private _sMetAba As String
        Private _sMetVlz As String '20
        Private _bRegAci As Boolean
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodGrp As String '1
            Get
                Return _sCodGrp
            End Get
            Set(ByVal value As String)
                _sCodGrp = value
            End Set
        End Property
        Public Property sNomGrp As String '2
            Get
                Return _sNomGrp
            End Get
            Set(ByVal value As String)
                _sNomGrp = value
            End Set
        End Property
        Public Property sCtaInv As String '3
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
        Public Property sCtaCosVta As String '4
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property sCtaTrs As String '5
            Get
                Return _sCtaTrs
            End Get
            Set(ByVal value As String)
                _sCtaTrs = value
            End Set
        End Property
        Public Property sCtaIng As String '6
            Get
                Return _sCtaIng
            End Get
            Set(ByVal value As String)
                _sCtaIng = value
            End Set
        End Property
        Public Property sCtaDevVta As String '7
            Get
                Return _sCtaDevVta
            End Get
            Set(ByVal value As String)
                _sCtaDevVta = value
            End Set
        End Property
        Public Property sCtaVrc As String '8
            Get
                Return _sCtaVrc
            End Get
            Set(ByVal value As String)
                _sCtaVrc = value
            End Set
        End Property
        Public Property sCtaGto As String '9
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
            End Set
        End Property
        Public Property sCtaDot As String '10
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String '11
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaRev As String '12
            Get
                Return _sCtaRev
            End Get
            Set(ByVal value As String)
                _sCtaRev = value
            End Set
        End Property
        Public Property sCtaAumInv As String '13
            Get
                Return _sCtaAumInv
            End Get
            Set(ByVal value As String)
                _sCtaAumInv = value
            End Set
        End Property
        Public Property sCtaRedInv As String '14
            Get
                Return _sCtaRedInv
            End Get
            Set(ByVal value As String)
                _sCtaRedInv = value
            End Set
        End Property
        Public Property sCtaCom As String '15
            Get
                Return _sCtaCom
            End Get
            Set(ByVal value As String)
                _sCtaCom = value
            End Set
        End Property
        Public Property sCtaDevCom As String '16
            Get
                Return _sCtaDevCom
            End Get
            Set(ByVal value As String)
                _sCtaDevCom = value
            End Set
        End Property
        Public Property sCtaWIP As String '17
            Get
                Return _sCtaWIP
            End Get
            Set(ByVal value As String)
                _sCtaWIP = value
            End Set
        End Property
        Public Property sSysInv As String '18
            Get
                Return _sSysInv
            End Get
            Set(ByVal value As String)
                _sSysInv = value
            End Set
        End Property
        Public Property sMetAba As String
            Get
                Return _sMetAba
            End Get
            Set(ByVal value As String)
                _sMetAba = value
            End Set
        End Property
        Public Property sMetVlz As String '20
            Get
                Return _sMetVlz
            End Get
            Set(ByVal value As String)
                _sMetVlz = value
            End Set
        End Property
        Public Property bRegAci As Boolean
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATGRT
        Private _nId As Long '0
        Private _sCodGruTer As String '1
        Private _sNomGruTer As String '2

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodGruTer As String '1
            Get
                Return _sCodGruTer
            End Get
            Set(ByVal value As String)
                _sCodGruTer = value
            End Set
        End Property
        Public Property sNomGruTer As String '2
            Get
                Return _sNomGruTer
            End Get
            Set(ByVal value As String)
                _sNomGruTer = value
            End Set
        End Property
    End Class
    Public Class eATGRV
        Private _nId As Long '0
        Private _sCodGrpVta As String '1
        Private _sNomGrpVta As String '2
        Private _bRegAci As Boolean

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodGrpVta As String '1
            Get
                Return _sCodGrpVta
            End Get
            Set(ByVal value As String)
                _sCodGrpVta = value
            End Set
        End Property
        Public Property sNomGrpVta As String '2
            Get
                Return _sNomGrpVta
            End Get
            Set(ByVal value As String)
                _sNomGrpVta = value
            End Set
        End Property
        Public Property bRegAci As Boolean
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATIVA
        Private _nId As Long '0
        Private _sCodIVA As String '1
        Private _sNomIVA As String '2
        Private _nPorIVA As Double '3
        Private _bVdoVta As Boolean '4
        Private _sCtaCbeVta As String '5
        Private _bVdoCom As Boolean '6
        Private _sCtaCbeCom As String '7
        Private _sClsDoc As String '8
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodIVA As String '1
            Get
                Return _sCodIVA
            End Get
            Set(ByVal value As String)
                _sCodIVA = value
            End Set
        End Property
        Public Property sNomIVA As String '2
            Get
                Return _sNomIVA
            End Get
            Set(ByVal value As String)
                _sNomIVA = value
            End Set
        End Property
        Public Property nPorIVA As Double '3
            Get
                Return _nPorIVA
            End Get
            Set(ByVal value As Double)
                _nPorIVA = value
            End Set
        End Property
        Public Property bVdoVta As Boolean '4
            Get
                Return _bVdoVta
            End Get
            Set(ByVal value As Boolean)
                _bVdoVta = value
            End Set
        End Property
        Public Property sCtaCbeVta As String '5
            Get
                Return _sCtaCbeVta
            End Get
            Set(ByVal value As String)
                _sCtaCbeVta = value
            End Set
        End Property
        Public Property bVdoCom As Boolean '6
            Get
                Return _bVdoCom
            End Get
            Set(ByVal value As Boolean)
                _bVdoCom = value
            End Set
        End Property
        Public Property sCtaCbeCom As String '7
            Get
                Return _sCtaCbeCom
            End Get
            Set(ByVal value As String)
                _sCtaCbeCom = value
            End Set
        End Property
        Public Property sClsDoc As String '7
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
    End Class
    Public Class eATMON
        Private _sCodMon As String '1
        Private _sNomMon As String '2
        Private _sCodIntMon As String '3
        Public Property sCodMon As String '1
            Get
                Return _sCodMon
            End Get
            Set(ByVal value As String)
                _sCodMon = value
            End Set
        End Property
        Public Property sNomMon As String '2
            Get
                Return _sNomMon
            End Get
            Set(ByVal value As String)
                _sNomMon = value
            End Set
        End Property
        Public Property sCodIntMon As String '3
            Get
                Return _sCodIntMon
            End Get
            Set(ByVal value As String)
                _sCodIntMon = value
            End Set
        End Property

    End Class
    Public Class eATOPE
        Private _nId As Long '0
        Private _sCodOpe As String '1
        Private _sNomOpe As String '2
        Private _sCodCtr As String '3
        Private _nTieOpe As Double '4
        Private _nUniTieOpe As Double '5
        Private _bRegAci As Boolean
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodOpe As String '1
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property sNomOpe As String '2
            Get
                Return _sNomOpe
            End Get
            Set(ByVal value As String)
                _sNomOpe = value
            End Set
        End Property
        Public Property sCodCtr As String '3
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nTieOpe As Double '4
            Get
                Return _nTieOpe
            End Get
            Set(ByVal value As Double)
                _nTieOpe = value
            End Set
        End Property
        Public Property nUniTieOpe As Double '5
            Get
                Return _nUniTieOpe
            End Get
            Set(ByVal value As Double)
                _nUniTieOpe = value
            End Set
        End Property
        Public Property bRegAci As Boolean
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATPCO
        Private _nId As Long '0
        Private _sCodPdo As String '1
        Private _sNomPdo As String '2
        Private _sEstPdo As String '3
        Private _dFecIni As Date '4
        Private _dFecFin As Date '5
        Private _sCodAno As String '6
        Private _bRegAci As Boolean '7
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodPdo As String '1
            Get
                Return _sCodPdo
            End Get
            Set(ByVal value As String)
                _sCodPdo = value
            End Set
        End Property
        Public Property sNomPdo As String '2
            Get
                Return _sNomPdo
            End Get
            Set(ByVal value As String)
                _sNomPdo = value
            End Set
        End Property
        Public Property sEstPdo As String '3
            Get
                Return _sEstPdo
            End Get
            Set(ByVal value As String)
                _sEstPdo = value
            End Set
        End Property
        Public Property dFecIni As Date '4
            Get
                Return _dFecIni
            End Get
            Set(ByVal value As Date)
                _dFecIni = value
            End Set
        End Property
        Public Property dFecFin As Date '5
            Get
                Return _dFecFin
            End Get
            Set(ByVal value As Date)
                _dFecFin = value
            End Set
        End Property
        Public Property sCodAno As String '6
            Get
                Return _sCodAno
            End Get
            Set(ByVal value As String)
                _sCodAno = value
            End Set
        End Property

        Public Property bRegAci As Boolean '7
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATPOP
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sNomTer As String '2
        Private _sTipTer As String '3
        Private _sNitTer As String '4
        Private _sDigVer As String '5
        Private _sDirTer As String '6
        Private _sTel1Ter As String '7
        Private _sTel2Ter As String '8
        Private _sTelCll As String '9
        Private _sFax As String '10
        Private _sNomAlt As String '11
        Private _sCodGrpTer As String '12
        Private _sEmlTer As String '13
        Private _sNomCtc As String '14
        Private _sTipCtaCtb As String '15
        Private _sCodCtaCtb As String '16
        Private _sCndPag As String '17
        Private _sCodLstPre As String '18
        Private _nPorDto As Double '19
        Private _nLmtCre As Double '20
        Private _bAct As Boolean '21
        Private _bIna As Boolean '22
        Private _sCmn As String '23
        Private _nSlrTer As Double '24
        Private _nCosTotMOD As Double
        Private _nUniTieOpe As Double
        Private _nPreUni As Double
        Private _bRegAci As Boolean '28
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String '2
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property sTipTer As String '3
            Get
                Return _sTipTer
            End Get
            Set(ByVal value As String)
                _sTipTer = value
            End Set
        End Property
        Public Property sNitTer As String '4
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sDigVer As String '5
            Get
                Return _sDigVer
            End Get
            Set(ByVal value As String)
                _sDigVer = value
            End Set
        End Property
        Public Property sDirTer As String '6
            Get
                Return _sDirTer
            End Get
            Set(ByVal value As String)
                _sDirTer = value
            End Set
        End Property
        Public Property sTel1Ter As String '7
            Get
                Return _sTel1Ter
            End Get
            Set(ByVal value As String)
                _sTel1Ter = value
            End Set
        End Property
        Public Property sTel2Ter As String '8
            Get
                Return _sTel2Ter
            End Get
            Set(ByVal value As String)
                _sTel2Ter = value
            End Set
        End Property
        Public Property sTelCll As String '9
            Get
                Return _sTelCll
            End Get
            Set(ByVal value As String)
                _sTelCll = value
            End Set
        End Property
        Public Property sFax As String '10
            Get
                Return _sFax
            End Get
            Set(ByVal value As String)
                _sFax = value
            End Set
        End Property
        Public Property sNomAlt As String '11
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodGrpTer As String '12
            Get
                Return _sCodGrpTer
            End Get
            Set(ByVal value As String)
                _sCodGrpTer = value
            End Set
        End Property
        Public Property sEmlTer As String '13
            Get
                Return _sEmlTer
            End Get
            Set(ByVal value As String)
                _sEmlTer = value
            End Set
        End Property
        Public Property sNomCtc As String '14
            Get
                Return _sNomCtc
            End Get
            Set(ByVal value As String)
                _sNomCtc = value
            End Set
        End Property
        Public Property sTipCtaCtb As String '15
            Get
                Return _sTipCtaCtb
            End Get
            Set(ByVal value As String)
                _sTipCtaCtb = value
            End Set
        End Property
        Public Property sCodCtaCtb As String '16
            Get
                Return _sCodCtaCtb
            End Get
            Set(ByVal value As String)
                _sCodCtaCtb = value
            End Set
        End Property
        Public Property sCndPag As String '17
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property sCodLstPre As String '18
            Get
                Return _sCodLstPre
            End Get
            Set(ByVal value As String)
                _sCodLstPre = value
            End Set
        End Property
        Public Property nPorDto As Double '19
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property nLmtCre As Double '20
            Get
                Return _nLmtCre
            End Get
            Set(ByVal value As Double)
                _nLmtCre = value
            End Set
        End Property
        Public Property bAct As Boolean '21
            Get
                Return _bAct
            End Get
            Set(ByVal value As Boolean)
                _bAct = value
            End Set
        End Property
        Public Property bIna As Boolean '22
            Get
                Return _bIna
            End Get
            Set(ByVal value As Boolean)
                _bIna = value
            End Set
        End Property
        Public Property sCmn As String '23
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property nCosTotMOD As Double '24
            Get
                Return _nCosTotMOD
            End Get
            Set(ByVal value As Double)
                _nCosTotMOD = value
            End Set
        End Property

        Public Property nUniTieOpe As Double '25
            Get
                Return _nUniTieOpe
            End Get
            Set(ByVal value As Double)
                _nUniTieOpe = value
            End Set
        End Property

        Public Property nPreUni As Double '26
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nSlrTer As Double '27
            Get
                Return _nSlrTer
            End Get
            Set(ByVal value As Double)
                _nSlrTer = value
            End Set
        End Property
        Public Property bRegAci As Boolean '28
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATTIA
        Private _sCodTipAna As String '0
        Private _sNomTipAna As String '1
        Public Property sCodTipAna As String '0
            Get
                Return _sCodTipAna
            End Get
            Set(ByVal value As String)
                _sCodTipAna = value
            End Set
        End Property
        Public Property sNomTipAna As String '1
            Get
                Return _sNomTipAna
            End Get
            Set(ByVal value As String)
                _sNomTipAna = value
            End Set
        End Property
    End Class
    Public Class eATTIN
        Private _nId As Long
        Private _sCodTra As String '0
        Private _sNomTra As String '1
        Private _sTipMov As String '2
        Private _bRegAci As Boolean '3
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTra As String '0
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property sNomTra As String '1
            Get
                Return _sNomTra
            End Get
            Set(ByVal value As String)
                _sNomTra = value
            End Set
        End Property
        Public Property sTipMov As String '1
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property bRegAci As Boolean '1
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATUME1
        Private _sUniMed As String
        Private _sNomMed As String
        Private _sCodVol As String
        Private _nVlrUme As Double
        Public Property sUniMed As String '0
            Get
                Return _sUniMed
            End Get
            Set(ByVal value As String)
                _sUniMed = value
            End Set
        End Property
        Public Property sNomMed As String
            Get
                Return _sNomMed
            End Get
            Set(ByVal value As String)
                _sNomMed = value
            End Set
        End Property
        Public Property sCodVol As String
            Get
                Return _sCodVol
            End Get
            Set(ByVal value As String)
                _sCodVol = value
            End Set
        End Property
        Public Property nVlrUme As Double '4
            Get
                Return _nVlrUme
            End Get
            Set(ByVal value As Double)
                _nVlrUme = value
            End Set
        End Property
    End Class
    Public Class eATUSR
        Private _nId As Long
        Private _sCodUsr As String
        Private _sNomUsr As String
        Private _sPwdUsr As String
        Private _sTipUsr As String
        Private _sEmlUsr As String
        Private _sTel1Usr As String
        Private _sTel2Usr As String
        Private _bUsrBlq As Boolean
        Private _bRegAci As Boolean
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodUsr As String '1
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sNomUsr As String '1
            Get
                Return _sNomUsr
            End Get
            Set(ByVal value As String)
                _sNomUsr = value
            End Set
        End Property

        Public Property sPwdUsr As String '1
            Get
                Return _sPwdUsr
            End Get
            Set(ByVal value As String)
                _sPwdUsr = value
            End Set
        End Property
        Public Property sTipUsr As String '1
            Get
                Return _sTipUsr
            End Get
            Set(ByVal value As String)
                _sTipUsr = value
            End Set
        End Property
        Public Property sEmlUsr As String '1
            Get
                Return _sEmlUsr
            End Get
            Set(ByVal value As String)
                _sEmlUsr = value
            End Set
        End Property

        Public Property sTel1Usr As String '1
            Get
                Return _sTel1Usr
            End Get
            Set(ByVal value As String)
                _sTel1Usr = value
            End Set
        End Property
        Public Property sTel2Usr As String '1
            Get
                Return _sTel2Usr
            End Get
            Set(ByVal value As String)
                _sTel2Usr = value
            End Set
        End Property
        Public Property bUsrBlq As Boolean '1
            Get
                Return _bUsrBlq
            End Get
            Set(ByVal value As Boolean)
                _bUsrBlq = value
            End Set
        End Property
        Public Property bRegAci As Boolean '1
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATVEN
        Private _nId As Long
        Private _sCodVen As String
        Private _sNomVen As String
        Private _sCodZon As String
        Private _sTipVen As String
        Private _bRegAci As Boolean
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodVen As String '1
            Get
                Return _sCodVen
            End Get
            Set(ByVal value As String)
                _sCodVen = value
            End Set
        End Property
        Public Property sNomVen As String '2
            Get
                Return _sNomVen
            End Get
            Set(ByVal value As String)
                _sNomVen = value
            End Set
        End Property
        Public Property sCodZon As String '3
            Get
                Return _sCodZon
            End Get
            Set(ByVal value As String)
                _sCodZon = value
            End Set
        End Property
        Public Property sTipVen As String '4
            Get
                Return _sTipVen
            End Get
            Set(ByVal value As String)
                _sTipVen = value
            End Set
        End Property
        Public Property bRegAci As Boolean '5
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
    Public Class eATZON
        Private _nId As Long
        Private _sCodZon As String
        Private _sNomZon As String
        Private _bRegAci As Boolean

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodZon As String '1
            Get
                Return _sCodZon
            End Get
            Set(ByVal value As String)
                _sCodZon = value
            End Set
        End Property
        Public Property sNomZon As String '2
            Get
                Return _sNomZon
            End Get
            Set(ByVal value As String)
                _sNomZon = value
            End Set
        End Property
        Public Property bRegAci As Boolean '3
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
    End Class
#End Region

#Region "Financiera"
    Public Class eFECTT
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroAsi As Long '2
        Private _sCodDocCtb As String '3
        Private _sCodSer As String '4
        Private _nNroDoc As Long '5
        Private _sCodTra As String '6
        Private _dFecCtb As Date '7
        Private _dFecDoc As Date '8
        Private _dFecVto As Date '9
        Private _dFecSys As Date '10
        Private _sCodDocBas As String '11
        Private _nNroDocBas As Long '12
        Private _nTotDeb As Double '13
        Private _nTotCre As Double '14
        Private _sCmn As String '15
        Private _sRef1 As String '16
        Private _sRef2 As String '17
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroAsi As Long '2
            Get
                Return _nNroAsi
            End Get
            Set(ByVal value As Long)
                _nNroAsi = value
            End Set
        End Property
        Public Property sCodDocCtb As String '3
            Get
                Return _sCodDocCtb
            End Get
            Set(ByVal value As String)
                _sCodDocCtb = value
            End Set
        End Property
        Public Property sCodSer As String '4
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property nNroDoc As Long '5
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodTra As String '6
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property dFecCtb As Date '7
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date '8
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date '9
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '10
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodDocBas As String '11
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long '12
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property nTotDeb As Long '13
            Get
                Return _nTotDeb
            End Get
            Set(ByVal value As Long)
                _nTotDeb = value
            End Set
        End Property
        Public Property nTotCre As Long '14
            Get
                Return _nTotCre
            End Get
            Set(ByVal value As Long)
                _nTotCre = value
            End Set
        End Property
        Public Property sCmn As String '15
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sRef1 As String '16
            Get
                Return _sRef1
            End Get
            Set(ByVal value As String)
                _sRef1 = value
            End Set
        End Property
        Public Property sRef2 As String '17
            Get
                Return _sRef2
            End Get
            Set(ByVal value As String)
                _sRef2 = value
            End Set
        End Property
    End Class
    Public Class eFLCTT1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroAsi As Long '2
        Private _sCodDocCtb As String '3
        Private _sCodSer As String '4
        Private _nNroDoc As Long '5
        Private _sCodTra As String '6
        Private _sCodCta As String '7
        Private _sCodTer As String '8
        Private _sNitTer As String '9
        Private _sNomTer As String '10
        Private _nVlrDeb As Double '11
        Private _nVlrCre As Double '12
        Private _sRef1 As String '13
        Private _sRef2 As String '14
        Private _sDetLin As String '15
        Private _sCodDocBas As String '16
        Private _nNroDocBas As Long '17
        Private _sCodCco As String '18
        Private _nVlrBasIto As Double '19
        Private _nPorIto As Double '20
        Private _sCodNIIF As String '21
        Private _sCodIto As String '22
        Private _nTasCamUsd As Double '23
        Private _nVlrBasUsd As Double '24
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroAsi As Long '2
            Get
                Return _nNroAsi
            End Get
            Set(ByVal value As Long)
                _nNroAsi = value
            End Set
        End Property
        Public Property sCodDocCtb As String '3
            Get
                Return _sCodDocCtb
            End Get
            Set(ByVal value As String)
                _sCodDocCtb = value
            End Set
        End Property
        Public Property sCodSer As String '4
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property nNroDoc As Long '5
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodTra As String '6
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property sCodCta As String '7
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property sCodTer As String '8
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNitTer As String '9
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sNomTer As String '10
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property nVlrDeb As Long '11
            Get
                Return _nVlrDeb
            End Get
            Set(ByVal value As Long)
                _nVlrDeb = value
            End Set
        End Property
        Public Property nVlrCre As Long '12
            Get
                Return _nVlrCre
            End Get
            Set(ByVal value As Long)
                _nVlrCre = value
            End Set
        End Property
        Public Property sRef1 As String '13
            Get
                Return _sRef1
            End Get
            Set(ByVal value As String)
                _sRef1 = value
            End Set
        End Property
        Public Property sRef2 As String '14
            Get
                Return _sRef2
            End Get
            Set(ByVal value As String)
                _sRef2 = value
            End Set
        End Property
        Public Property sDetLin As String '15
            Get
                Return _sDetLin
            End Get
            Set(ByVal value As String)
                _sDetLin = value
            End Set
        End Property
        Public Property sCodDocBas As String '16
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long '17
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCodCco As String '18
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property nVlrBasIto As Double '19
            Get
                Return _nVlrBasIto
            End Get
            Set(ByVal value As Double)
                _nVlrBasIto = value
            End Set
        End Property
        Public Property nPorIto As Double '20
            Get
                Return _nPorIto
            End Get
            Set(ByVal value As Double)
                _nPorIto = value
            End Set
        End Property
        Public Property sCodNIIF As String '21
            Get
                Return _sCodNIIF
            End Get
            Set(ByVal value As String)
                _sCodNIIF = value
            End Set
        End Property
        Public Property sCodIto As String '22
            Get
                Return _sCodIto
            End Get
            Set(ByVal value As String)
                _sCodIto = value
            End Set
        End Property
        Public Property nTasCamUsd As String '23
            Get
                Return _nTasCamUsd
            End Get
            Set(ByVal value As String)
                _nTasCamUsd = value
            End Set
        End Property
        Public Property nVlrBasUsd As String '24
            Get
                Return _nVlrBasUsd
            End Get
            Set(ByVal value As String)
                _nVlrBasUsd = value
            End Set
        End Property
    End Class
    Public Class eFEMOC
        Private _nId As Long '0
        Private _sCodDoc As Long '1
        Private _sCodSer As String '2
        Private _sTipMov As Long '3
        Private _sClsDoc As String '4
        Private _sCodDocCtb As String '5
        Private _sCodSerCtb As String '6
        Private _sCodTra As String '7
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sCodSer As String '2
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipMov As String '3
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sClsDoc As String '4
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCodDocCtb As String '5
            Get
                Return _sCodDocCtb
            End Get
            Set(ByVal value As String)
                _sCodDocCtb = value
            End Set
        End Property
        Public Property sCodSerCtb As String '6
            Get
                Return _sCodSerCtb
            End Get
            Set(ByVal value As String)
                _sCodSerCtb = value
            End Set
        End Property
        Public Property sCodTra As String '7
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
    End Class
    Public Class eFLMOC1
        Private _nId As Long '0
        Private _sCodDoc As Long '1
        Private _sNomCmp As String '2
        Private _sDeb As String '3
        Private _sCre As String '4
        Private _sDebCre As String '5
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sNomCmp As String '2
            Get
                Return _sNomCmp
            End Get
            Set(ByVal value As String)
                _sNomCmp = value
            End Set
        End Property
        Public Property sDeb As String '3
            Get
                Return _sDeb
            End Get
            Set(ByVal value As String)
                _sDeb = value
            End Set
        End Property
        Public Property sCre As String '4
            Get
                Return _sCre
            End Get
            Set(ByVal value As String)
                _sCre = value
            End Set
        End Property
        Public Property sDebCre As String '5
            Get
                Return _sDebCre
            End Get
            Set(ByVal value As String)
                _sDebCre = value
            End Set
        End Property
    End Class
    Public Class eFTPUC
        Private _nId As Long '0
        Private _sCodCta As String '1
        Private _sNomCta As String '2
        Private _sCodCtaAlt As String '3
        Private _sNomAlt As String '4
        Private _sCodNIIF As String '5
        Private _bCtaFluCaj As Boolean '6
        Private _bCtaPpo As Boolean '7
        Private _sClsCta As String '8
        Private _nSdoIniCta As Double '9
        Private _nSdoFinCta As Double '10
        Private _sNivCta As String '11
        Private _sCodCtaSup As String '12
        Private _bCtaRcc As Boolean '13
        Private _sCodCtaRcc As String '14
        Private _bCtaCfd As Boolean '15
        Private _bCtaTer As Boolean '16
        Private _bCtaBlq As Boolean '17
        Private _bCtaMov As Boolean '18
        Private _bCtaIna As Boolean '19
        Public Property nID As Long '1
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCta As String '1
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property sNomCta As String '2
            Get
                Return _sNomCta
            End Get
            Set(ByVal value As String)
                _sNomCta = value
            End Set
        End Property
        Public Property sCodCtaAlt As String '3
            Get
                Return _sCodCtaAlt
            End Get
            Set(ByVal value As String)
                _sCodCtaAlt = value
            End Set
        End Property
        Public Property sNomAlt As String '4
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodNIIF As String '5
            Get
                Return _sCodNIIF
            End Get
            Set(ByVal value As String)
                _sCodNIIF = value
            End Set
        End Property
        Public Property bCtaFluCaj As Boolean '6
            Get
                Return _bCtaFluCaj
            End Get
            Set(ByVal value As Boolean)
                _bCtaFluCaj = value
            End Set
        End Property
        Public Property bCtaPpo As Boolean '7
            Get
                Return _bCtaPpo
            End Get
            Set(ByVal value As Boolean)
                _bCtaPpo = value
            End Set
        End Property
        Public Property sClsCta As String '8
            Get
                Return _sClsCta
            End Get
            Set(ByVal value As String)
                _sClsCta = value
            End Set
        End Property
        Public Property nSdoIniCta As Double '9
            Get
                Return _nSdoIniCta
            End Get
            Set(ByVal value As Double)
                _nSdoIniCta = value
            End Set
        End Property
        Public Property nSdoFinCta As Double '10
            Get
                Return _nSdoFinCta
            End Get
            Set(ByVal value As Double)
                _nSdoFinCta = value
            End Set
        End Property
        Public Property sNivCta As String '11
            Get
                Return _sNivCta
            End Get
            Set(ByVal value As String)
                _sNivCta = value
            End Set
        End Property
        Public Property sCodCtaSup As String '12
            Get
                Return _sCodCtaSup
            End Get
            Set(ByVal value As String)
                _sCodCtaSup = value
            End Set
        End Property
        Public Property bCtaRcc As Boolean '13
            Get
                Return _bCtaRcc
            End Get
            Set(ByVal value As Boolean)
                _bCtaRcc = value
            End Set
        End Property
        Public Property sCodCtaRcc As String '14
            Get
                Return _sCodCtaRcc
            End Get
            Set(ByVal value As String)
                _sCodCtaRcc = value
            End Set
        End Property
        Public Property bCtaCfd As Boolean '15
            Get
                Return _bCtaCfd
            End Get
            Set(ByVal value As Boolean)
                _bCtaCfd = value
            End Set
        End Property
        Public Property bCtaTer As Boolean '16
            Get
                Return _bCtaTer
            End Get
            Set(ByVal value As Boolean)
                _bCtaTer = value
            End Set
        End Property
        Public Property bCtaBlq As Boolean '17
            Get
                Return _bCtaBlq
            End Get
            Set(ByVal value As Boolean)
                _bCtaBlq = value
            End Set
        End Property
        Public Property bCtaMov As Boolean '18
            Get
                Return _bCtaMov
            End Get
            Set(ByVal value As Boolean)
                _bCtaMov = value
            End Set
        End Property
        Public Property bCtaIna As Boolean '19
            Get
                Return _bCtaIna
            End Get
            Set(ByVal value As Boolean)
                _bCtaIna = value
            End Set
        End Property
    End Class
    Public Class eFTSAC
        Private _nId As Long '0
        Private _sCodCta As String '1
        Private _nSdoIniCta As Double '2
        Private _nSdoCta As Double '3

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCta As String '1
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property nSdoIniCta As Double '2
            Get
                Return _nSdoIniCta
            End Get
            Set(ByVal value As Double)
                _nSdoIniCta = value
            End Set
        End Property

        Public Property nSdoFinCta As Double '3
            Get
                Return _nSdoCta
            End Get
            Set(ByVal value As Double)
                _nSdoCta = value
            End Set
        End Property
    End Class
    Public Class eFTSAT
        Private _nId As Long '0
        Private _sCodCta As String '1
        Private _sCodTer As String '2
        Private _sNitTer As String '3
        Private _nSdoIniTer As Double '4
        Private _nSdoTer As Double '5

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCta As String '1
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property sCodTer As String '2
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNitTer As String '3
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property nSdoIniTer As Double '4
            Get
                Return _nSdoIniTer
            End Get
            Set(ByVal value As Double)
                _nSdoIniTer = value
            End Set
        End Property
        Public Property nSdoTer As Double '5
            Get
                Return _nSdoTer
            End Get
            Set(ByVal value As Double)
                _nSdoTer = value
            End Set
        End Property
    End Class
#End Region

#Region "Generica de movimiento"
    Public Class eGEMOV
        Private _nID As Long       '0
        Private _nIDEnc As Long       '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long
        Private _sCodSer As String
        Private _sCodTra As String
        Private _sEstDoc As String '5
        Private _sTipMov As String
        Private _dFecCtb As Date
        Private _dFecDoc As Date
        Private _dFecVto As Date
        Private _dFecSys As Date   '10
        Private _sCodTer As String
        Private _sNomTer As String
        Private _nPorDto As Double
        Private _sAlmOri As String
        Private _sDocRef As String '15
        Private _nTotBas As Double
        Private _nTotDto As Double
        Private _nTotGtoAdi As Double
        Private _nTotIvaCom As Double
        Private _nTotIvaVta As Double '20
        Private _nVlrRdd As Double
        Private _nTotDoc As Double
        Private _sCodDocBas As String
        Private _nNroDocBas As Long
        Private _sCndPag As String '25
        Private _sClsDoc As String
        Private _sTipDoc As String
        Private _sCodVen As String
        Private _sDirTer As String
        Private _sCiuTer As String '30
        Private _sDepTer As String
        Private _sPaiTer As String
        Private _sCmn As String
        Private _sCodCteCtb As String
        Private _nNroCtectb As Long '35
        Private _nIdFECCT As Long
        Private _sNITTer As String
        Private _sCodMon As String
        Private _sCodUsr As String
        Private _sCodAut As String '40
        Private _bPrp01 As Boolean
        Private _bPrp02 As Boolean
        Private _bPrp03 As Boolean

        Public Property nID As Long '0
            Get
                Return _nID
            End Get
            Set(ByVal value As Long)
                _nID = value
            End Set
        End Property
        Public Property nIDEnc As Long '0
            Get
                Return _nIDEnc
            End Get
            Set(ByVal value As Long)
                _nIDEnc = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sEstDoc As String '3
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property sCodSer As String '4
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodTra As String '5
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property sTipMov As String
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property dFecCtb As Date
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '10
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodTer As String
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property nPorDto As Double '13
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property sAlmOri As String
            Get
                Return _sAlmOri
            End Get
            Set(ByVal value As String)
                _sAlmOri = value
            End Set
        End Property
        Public Property sDocRef As String '15
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotBas As Double
            Get
                Return _nTotBas
            End Get
            Set(ByVal value As Double)
                _nTotBas = value
            End Set
        End Property
        Public Property nTotDto As Double
            Get
                Return _nTotDto
            End Get
            Set(ByVal value As Double)
                _nTotDto = value
            End Set
        End Property
        Public Property nTotGtoAdi As Double
            Get
                Return _nTotGtoAdi
            End Get
            Set(ByVal value As Double)
                _nTotGtoAdi = value
            End Set
        End Property
        Public Property nTotIvaCom As Double
            Get
                Return _nTotIvaCom
            End Get
            Set(ByVal value As Double)
                _nTotIvaCom = value
            End Set
        End Property
        Public Property nTotIvaVta As Double '20
            Get
                Return _nTotIvaVta
            End Get
            Set(ByVal value As Double)
                _nTotIvaVta = value
            End Set
        End Property
        Public Property nVlrRdd As Double
            Get
                Return _nVlrRdd
            End Get
            Set(ByVal value As Double)
                _nVlrRdd = value
            End Set
        End Property
        Public Property nTotDoc As Double
            Get
                Return _nTotDoc
            End Get
            Set(ByVal value As Double)
                _nTotDoc = value
            End Set
        End Property
        Public Property sCodDocBas As String
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCndPag As String '25
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property sClsDoc As String
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sTipDoc As String
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sCodVen As String
            Get
                Return _sCodVen
            End Get
            Set(ByVal value As String)
                _sCodVen = value
            End Set
        End Property
        Public Property sDirTer As String
            Get
                Return _sDirTer
            End Get
            Set(ByVal value As String)
                _sDirTer = value
            End Set
        End Property
        Public Property sCiuter As String '30
            Get
                Return _sCiuTer
            End Get
            Set(ByVal value As String)
                _sCiuTer = value
            End Set
        End Property
        Public Property sDepTer As String
            Get
                Return _sDepTer
            End Get
            Set(ByVal value As String)
                _sDepTer = value
            End Set
        End Property
        Public Property sPaiTer As String
            Get
                Return _sPaiTer
            End Get
            Set(ByVal value As String)
                _sPaiTer = value
            End Set
        End Property
        Public Property sCmn As String
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sCodCteCtb As String
            Get
                Return _sCodCteCtb
            End Get
            Set(ByVal value As String)
                _sCodCteCtb = value
            End Set
        End Property
        Public Property nNroCteCtb As Long '35
            Get
                Return _nNroCtectb
            End Get
            Set(ByVal value As Long)
                _nNroCtectb = value
            End Set
        End Property
        Public Property nIdFECCT As Long
            Get
                Return _nIdFECCT
            End Get
            Set(ByVal value As Long)
                _nIdFECCT = value
            End Set
        End Property
        Public Property sNitTer As String
            Get
                Return _sNITTer
            End Get
            Set(ByVal value As String)
                _sNITTer = value
            End Set
        End Property
        Public Property sCodMon As String
            Get
                Return _sCodMon
            End Get
            Set(ByVal value As String)
                _sCodMon = value
            End Set
        End Property
        Public Property sCodUsr As String
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sCodAut As String '40
            Get
                Return _sCodAut
            End Get
            Set(ByVal value As String)
                _sCodAut = value
            End Set
        End Property
        Public Property bPrp01 As Boolean
            Get
                Return _bPrp01
            End Get
            Set(ByVal value As Boolean)
                _bPrp01 = value
            End Set
        End Property
        Public Property bPrp02 As Boolean
            Get
                Return _bPrp02
            End Get
            Set(ByVal value As Boolean)
                _bPrp02 = value
            End Set
        End Property
        Public Property bPrp03 As Boolean
            Get
                Return _bPrp03
            End Get
            Set(ByVal value As Boolean)
                _bPrp03 = value
            End Set
        End Property

    End Class
    Public Class eGLMOV1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2 
        Private _sTipMov As String '3
        Private _sCodDocBas As String '4
        Private _sCodSerBas As String '5
        Private _nNroDocBas As Long
        Private _sCodItm As String '
        Private _sNomItm As String '
        Private _sNomAlt As String '
        Private _sCodAlm As String '10
        Private _nCanItm As Double ' 
        Private _sUniMedInv As String '
        Private _nPreUni As Double '
        Private _nVlrBas As Double '
        Private _nPorDto As Double '15
        Private _nVlrDto As Double '
        Private _nPreDto As Double '
        Private _nVlrDtoLin As Double '
        Private _sCodIva As String '
        Private _nPorIva As Double '20
        Private _nVlrIva As Double '
        Private _nVlrIvaLin As Double '
        Private _nPreBru As Double '
        Private _nTotLin As Double '
        Private _nPorCms As Double '25
        Private _sCodCco As String '
        Private _sTipLIM As String '
        Private _sCodVen As String '
        Private _nLinBas As Long '
        Private _sCodPdo As String '30
        Private _sCodCta As String '
        Private _bSolIto As Boolean '
        Private _sCtaCosVta As String '
        Private _bItmBlq As Boolean '
        Private _sCodSer As String '35
        Private _sClsDoc As String '
        Private _nTasCamUsd As Double '
        Private _nPreUniUsd As Double '
        Private _nVlrBasUsd As Double '
        Private _sCodRch As String '40
        Private _sNroLot As String '41
        Private _nSdoCanLin As Double '42
        Private _nPesProm As Double '43
        '  Private _sCodMon As String '43
        'Adicionales
        Private _nSdoAlm As Double '44
        Private _nSdoInv As Double
        Private _bIndCan As Boolean
        Private _bIndCos As Boolean
        Private _bIndLibODP As Boolean
        Private _nUltPreEnt As Double '48

        Private _bIndCanRes As Boolean
        Private _bIndCanPry As Boolean
        Private _nSdoIni As Double
        Private _nSdoIniAno As Double
        Private _nCanResODP As Double
        Private _nSdoFinDis As Double
        Private _nCanPedODC As Double
        Private _nSdoFinPry As Double
        Private _nLeadTime As Double

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sTipMov As String '3
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sCodDocBas As String '4
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property sCodSerBas As String '5
            Get
                Return _sCodSerBas
            End Get
            Set(ByVal value As String)

                _sCodSerBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCodItm As String
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sNomItm As String
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodAlm As String '10
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nCanItm As Double
            Get
                Return _nCanItm
            End Get
            Set(ByVal value As Double)
                _nCanItm = value
            End Set
        End Property
        Public Property sUniMedInv As String
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nPreUni As Double
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nVlrBas As Double
            Get
                Return _nVlrBas
            End Get
            Set(ByVal value As Double)
                _nVlrBas = value
            End Set
        End Property
        Public Property nPorDto As Double '15
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property nVlrDto As Double
            Get
                Return _nVlrDto
            End Get
            Set(ByVal value As Double)
                _nVlrDto = value
            End Set
        End Property
        Public Property nPreDto As Double
            Get
                Return _nPreDto
            End Get
            Set(ByVal value As Double)
                _nPreDto = value
            End Set
        End Property
        Public Property nVlrDtoLin As Double
            Get
                Return _nVlrDtoLin
            End Get
            Set(ByVal value As Double)
                _nVlrDtoLin = value
            End Set
        End Property
        Public Property sCodIva As String
            Get
                Return _sCodIva
            End Get
            Set(ByVal value As String)
                _sCodIva = value
            End Set
        End Property
        Public Property nPorIva As Double '20
            Get
                Return _nPorIva
            End Get
            Set(ByVal value As Double)
                _nPorIva = value
            End Set
        End Property
        Public Property nVlrIva As Double
            Get
                Return _nVlrIva
            End Get
            Set(ByVal value As Double)
                _nVlrIva = value
            End Set
        End Property
        Public Property nVlrIvaLin As Double
            Get
                Return _nVlrIvaLin
            End Get
            Set(ByVal value As Double)
                _nVlrIvaLin = value
            End Set
        End Property
        Public Property nPreBru As Double
            Get
                Return _nPreBru
            End Get
            Set(ByVal value As Double)
                _nPreBru = value
            End Set
        End Property
        Public Property nTotLin As Double
            Get
                Return _nTotLin
            End Get
            Set(ByVal value As Double)
                _nTotLin = value
            End Set
        End Property
        Public Property nPorCms As Double '25
            Get
                Return _nPorCms
            End Get
            Set(ByVal value As Double)
                _nPorCms = value
            End Set
        End Property
        Public Property sCodCco As String
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property sTipLIM As String
            Get
                Return _sTipLIM
            End Get
            Set(ByVal value As String)
                _sTipLIM = value
            End Set
        End Property
        Public Property sCodVen As String
            Get
                Return _sCodVen
            End Get
            Set(ByVal value As String)
                _sCodVen = value
            End Set
        End Property
        Public Property nLinBas As Long
            Get
                Return _nLinBas
            End Get
            Set(ByVal value As Long)
                _nLinBas = value
            End Set
        End Property
        Public Property sCodPdo As String '30
            Get
                Return _sCodPdo
            End Get
            Set(ByVal value As String)
                _sCodPdo = value
            End Set
        End Property
        Public Property sCodCta As String
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property bSolIto As Boolean
            Get
                Return _bSolIto
            End Get
            Set(ByVal value As Boolean)
                _bSolIto = value
            End Set
        End Property
        Public Property sCtaCosVta As String
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property bItmBlq As Boolean
            Get
                Return _bItmBlq
            End Get
            Set(ByVal value As Boolean)
                _bItmBlq = value
            End Set
        End Property
        Public Property sCodSer As String '35
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sClsDoc As String
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property nTasCamUsd As Double
            Get
                Return _nTasCamUsd
            End Get
            Set(ByVal value As Double)
                _nTasCamUsd = value
            End Set
        End Property
        Public Property nPreUniUsd As Double
            Get
                Return _nPreUniUsd
            End Get
            Set(ByVal value As Double)
                _nPreUniUsd = value
            End Set
        End Property
        Public Property nVlrBasUsd As Double
            Get
                Return _nVlrBasUsd
            End Get
            Set(ByVal value As Double)
                _nVlrBasUsd = value
            End Set
        End Property
        Public Property sCodRch As String '40
            Get
                Return _sCodRch
            End Get
            Set(ByVal value As String)
                _sCodRch = value
            End Set
        End Property
        Public Property sNroLot As String
            Get
                Return _sNroLot
            End Get
            Set(ByVal value As String)
                _sNroLot = value
            End Set
        End Property
        Public Property nSdoCanLin As Double
            Get
                Return _nSdoCanLin
            End Get
            Set(ByVal value As Double)
                _nSdoCanLin = value
            End Set
        End Property
        Public Property nPesProm As Double '43
            Get
                Return _nPesProm
            End Get
            Set(ByVal value As Double)
                _nPesProm = value
            End Set
        End Property
        '   Public Property sCodMon As String
        '       Get
        '           Return _sCodMon
        '       End Get
        '       Set(ByVal value As String)
        '           _sCodMon = value
        '      End Set
        '  End Property
        Public Property nSdoAlm As Double '44
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property nSdoInv As Double
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property bIndCan As Boolean
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property bIndLibODP As Boolean
            Get
                Return _bIndLibODP
            End Get
            Set(ByVal value As Boolean)
                _bIndLibODP = value
            End Set
        End Property
        Public Property nUltPreEnt As Double '49
            Get
                Return _nUltPreEnt
            End Get
            Set(ByVal value As Double)
                _nUltPreEnt = value
            End Set
        End Property

        Public Property bIndCanRes As Boolean
            Get
                Return _bIndCanRes
            End Get
            Set(ByVal value As Boolean)
                _bIndCanRes = value
            End Set
        End Property
        Public Property bIndCanPry As Boolean
            Get
                Return _bIndCanPry
            End Get
            Set(ByVal value As Boolean)
                _bIndCanPry = value
            End Set
        End Property

        Public Property nSdoIni As Double
            Get
                Return _nSdoIni
            End Get
            Set(ByVal value As Double)
                _nSdoIni = value
            End Set
        End Property
        Public Property nSdoIniAno As Double
            Get
                Return _nSdoIniAno
            End Get
            Set(ByVal value As Double)
                _nSdoIniAno = value
            End Set
        End Property
        Public Property nCanResODP As Double
            Get
                Return _nCanResODP
            End Get
            Set(ByVal value As Double)
                _nCanResODP = value
            End Set
        End Property
        Public Property nSdoFinDis As Double
            Get
                Return _nSdoFinDis
            End Get
            Set(ByVal value As Double)
                _nSdoFinDis = value
            End Set
        End Property
        Public Property nCanPedODC As Double
            Get
                Return _nCanPedODC
            End Get
            Set(ByVal value As Double)
                _nCanPedODC = value
            End Set
        End Property
        Public Property nSdoFinPry As Double
            Get
                Return _nSdoFinPry
            End Get
            Set(ByVal value As Double)
                _nSdoFinPry = value
            End Set
        End Property
        Public Property nLeadTime As Double
            Get
                Return _nLeadTime
            End Get
            Set(ByVal value As Double)
                _nLeadTime = value
            End Set
        End Property


    End Class
    ' Public Class eGELMOV1
    ' Private _eGEMOV As New eGEMOV '0
    ' Private _eGLMOV1 As New eGLMOV1 '0
    ' Public Property eGEMOV As eGEMOV
    '    Get
    '        Return _eGEMOV
    '    End Get
    '    Set(ByVal value As eGEMOV)
    '        _eGEMOV = value
    '    End Set
    'End Property
    'Public Property eGLMOV1 As eGLMOV1
    '    Get
    '        Return _eGLMOV1
    '    End Get
    '    Set(ByVal value As eGLMOV1)
    '        _eGLMOV1 = value
    '    End Set
    'End Property
    'End Class
    Public Class aeGLMOV1
        Dim aeGLMOV1(0) As eGLMOV1
        Private _eGLMOV1 As eGLMOV1
        Public Property eGLMOV1 As eGLMOV1 '0
            Get
                Return _eGLMOV1
            End Get
            Set(ByVal value As eGLMOV1)
                _eGLMOV1 = value
            End Set
        End Property
    End Class
    Public Class eGELMOV1
        Private _nID As Long       '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long
        Private _sCodSer As String
        Private _sCodTra As String
        Private _sEstDoc As String '5
        Private _sTipMov As String
        Private _dFecCtb As Date
        Private _dFecDoc As Date
        Private _dFecVto As Date
        Private _dFecSys As Date   '10
        Private _sCodTer As String
        Private _sNomTer As String
        Private _nPorDto As Double
        Private _sAlmOri As String
        Private _sDocRef As String '15
        Private _nTotBas As Double
        Private _nTotDto As Double
        Private _nTotGtoAdi As Double
        Private _nTotIvaCom As Double
        Private _nTotIvaVta As Double '20
        Private _nVlrRdd As Double
        Private _nTotDoc As Double
        Private _sCodDocBas As String
        Private _nNroDocBas As Long
        Private _sCndPag As String '25
        Private _sClsDoc As String
        Private _sTipDoc As String
        Private _sCodVen As String
        Private _sDirTer As String
        Private _sCiuTer As String '30
        Private _sDepTer As String
        Private _sPaiTer As String
        Private _sCmn As String
        Private _sCodCteCtb As String
        Private _nNroCtectb As Long '35
        Private _nIdFECCT As Long
        Private _sNITTer As String
        Private _sCodMon As String
        Private _sCodUsr As String
        Private _sCodAut As String

        Private _bPrp01 As Boolean
        Private _bPrp02 As Boolean
        Private _bPrp03 As Boolean

        Private _xnId As Long '0
        Private _xsCodDoc As String '1
        Private _xnNroDoc As Long '2 
        Private _xsCodSer As String '3
        Private _xsTipMov As String '4
        Private _xsCodDocBas As String '5
        Private _xsCodSerBas As String
        Private _xnNroDocBas As Long
        Private _xsCodItm As String
        Private _xsNomItm As String
        Private _xsNomAlt As String '10
        Private _xsCodAlm As String
        Private _xnCanItm As Double
        Private _xsUniMedInv As String
        Private _xnPreUni As Double
        Private _xnVlrBas As Double '15
        Private _xnPorDto As Double
        Private _xnVlrDto As Double
        Private _xnPreDto As Double
        Private _xnVlrDtoLin As Double
        Private _xsCodIva As String '20
        Private _xnPorIva As Double
        Private _xnVlrIva As Double
        Private _xnVlrIvaLin As Double
        Private _xnPreBru As Double
        Private _xnTotLin As Double '25
        Private _xnPorCms As Double
        Private _xsCodCco As String
        Private _xsTipLIM As String
        Private _xsCodVen As String
        Private _xnLinBas As Long '30
        Private _xsCodPdo As String
        Private _xsCodCta As String
        Private _xbSolIto As Boolean
        Private _xsCtaCosVta As String
        Private _xbItmBlq As Boolean '35
        Private _xsClsDoc As String
        Private _xnTasCamUsd As Double
        Private _xnPreUniUsd As Double
        Private _xnVlrBasUsd As Double
        Private _xsCodRch As String '40
        Private _xsNroLot As String
        Private _xnSdoCanLin As Double
        Private _xnPesProm As Double '43
        'Private _xnCodMon As String '43
        'Adicionales
        Private _xnSdoInv As Double
        Private _xnSdoAlm As Double
        Private _xbIndCan As Boolean
        Private _xbIndCos As Boolean
        Private _xbIndLibODP As Boolean
        Private _xnUltPreEnt As Double

        Public Property nID As Long '0
            Get
                Return _nID
            End Get
            Set(ByVal value As Long)
                _nID = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sEstDoc As String '3
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property sCodSer As String '4
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodTra As String '5
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property sTipMov As String
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property dFecCtb As Date
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '10
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodTer As String
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property nPorDto As Double '13
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property sAlmOri As String
            Get
                Return _sAlmOri
            End Get
            Set(ByVal value As String)
                _sAlmOri = value
            End Set
        End Property
        Public Property sDocRef As String '15
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotBas As Double
            Get
                Return _nTotBas
            End Get
            Set(ByVal value As Double)
                _nTotBas = value
            End Set
        End Property
        Public Property nTotDto As Double
            Get
                Return _nTotDto
            End Get
            Set(ByVal value As Double)
                _nTotDto = value
            End Set
        End Property
        Public Property nTotGtoAdi As Double
            Get
                Return _nTotGtoAdi
            End Get
            Set(ByVal value As Double)
                _nTotGtoAdi = value
            End Set
        End Property
        Public Property nTotIvaCom As Double
            Get
                Return _nTotIvaCom
            End Get
            Set(ByVal value As Double)
                _nTotIvaCom = value
            End Set
        End Property
        Public Property nTotIvaVta As Double '20
            Get
                Return _nTotIvaVta
            End Get
            Set(ByVal value As Double)
                _nTotIvaVta = value
            End Set
        End Property
        Public Property nVlrRdd As Double
            Get
                Return _nVlrRdd
            End Get
            Set(ByVal value As Double)
                _nVlrRdd = value
            End Set
        End Property
        Public Property nTotDoc As Double
            Get
                Return _nTotDoc
            End Get
            Set(ByVal value As Double)
                _nTotDoc = value
            End Set
        End Property
        Public Property sCodDocBas As String
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCndPag As String '25
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property sClsDoc As String
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sTipDoc As String
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sCodVen As String
            Get
                Return _sCodVen
            End Get
            Set(ByVal value As String)
                _sCodVen = value
            End Set
        End Property
        Public Property sDirTer As String
            Get
                Return _sDirTer
            End Get
            Set(ByVal value As String)
                _sDirTer = value
            End Set
        End Property
        Public Property sCiuter As String '30
            Get
                Return _sCiuTer
            End Get
            Set(ByVal value As String)
                _sCiuTer = value
            End Set
        End Property
        Public Property sDepTer As String
            Get
                Return _sDepTer
            End Get
            Set(ByVal value As String)
                _sDepTer = value
            End Set
        End Property
        Public Property sPaiTer As String
            Get
                Return _sPaiTer
            End Get
            Set(ByVal value As String)
                _sPaiTer = value
            End Set
        End Property
        Public Property sCmn As String
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sCodCteCtb As String
            Get
                Return _sCodCteCtb
            End Get
            Set(ByVal value As String)
                _sCodCteCtb = value
            End Set
        End Property
        Public Property nNroCteCtb As Long '35
            Get
                Return _nNroCtectb
            End Get
            Set(ByVal value As Long)
                _nNroCtectb = value
            End Set
        End Property
        Public Property nIdFECCT As Long
            Get
                Return _nIdFECCT
            End Get
            Set(ByVal value As Long)
                _nIdFECCT = value
            End Set
        End Property
        Public Property sNitTer As String
            Get
                Return _sNITTer
            End Get
            Set(ByVal value As String)
                _sNITTer = value
            End Set
        End Property
        Public Property sCodMon As String
            Get
                Return _sCodMon
            End Get
            Set(ByVal value As String)
                _sCodMon = value
            End Set
        End Property
        Public Property sCodUsr As String
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sCodAut As String '40
            Get
                Return _sCodAut
            End Get
            Set(ByVal value As String)
                _sCodAut = value
            End Set
        End Property

        Public Property bPrp01 As Boolean
            Get
                Return _bPrp01
            End Get
            Set(ByVal value As Boolean)
                _bPrp01 = value
            End Set
        End Property
        Public Property bPrp02 As Boolean
            Get
                Return _bPrp02
            End Get
            Set(ByVal value As Boolean)
                _bPrp02 = value
            End Set
        End Property
        Public Property bPrp03 As Boolean
            Get
                Return _bPrp03
            End Get
            Set(ByVal value As Boolean)
                _bPrp03 = value
            End Set
        End Property



        Public Property xnID As Long '0
            Get
                Return _xnId
            End Get
            Set(ByVal value As Long)
                _xnId = value
            End Set
        End Property
        Public Property xsCodDoc As String '1
            Get
                Return _xsCodDoc
            End Get
            Set(ByVal value As String)
                _xsCodDoc = value
            End Set
        End Property
        Public Property xnNroDoc As Long '2
            Get
                Return _xnNroDoc
            End Get
            Set(ByVal value As Long)
                _xnNroDoc = value
            End Set
        End Property
        Public Property xsTipMov As String '3
            Get
                Return _xsTipMov
            End Get
            Set(ByVal value As String)
                _xsTipMov = value
            End Set
        End Property
        Public Property xsCodDocBas As String '4
            Get
                Return _xsCodDocBas
            End Get
            Set(ByVal value As String)
                _xsCodDocBas = value
            End Set
        End Property
        Public Property xsCodSerBas As String '4
            Get
                Return _xsCodSerBas
            End Get
            Set(ByVal value As String)
                _xsCodSerBas = value
            End Set
        End Property
        Public Property xnNroDocBas As Long '5
            Get
                Return _xnNroDocBas
            End Get
            Set(ByVal value As Long)
                _xnNroDocBas = value
            End Set
        End Property
        Public Property xsCodItm As String '6
            Get
                Return _xsCodItm
            End Get
            Set(ByVal value As String)
                _xsCodItm = value
            End Set
        End Property
        Public Property xsNomItm As String '7
            Get
                Return _xsNomItm
            End Get
            Set(ByVal value As String)
                _xsNomItm = value
            End Set
        End Property
        Public Property xsNomAlt As String '8
            Get
                Return _xsNomAlt
            End Get
            Set(ByVal value As String)
                _xsNomAlt = value
            End Set
        End Property
        Public Property xsCodAlm As String '9
            Get
                Return _xsCodAlm
            End Get
            Set(ByVal value As String)
                _xsCodAlm = value
            End Set
        End Property
        Public Property xnCanItm As Double '10
            Get
                Return _xnCanItm
            End Get
            Set(ByVal value As Double)
                _xnCanItm = value
            End Set
        End Property
        Public Property xsUniMedInv As String '11
            Get
                Return _xsUniMedInv
            End Get
            Set(ByVal value As String)
                _xsUniMedInv = value
            End Set
        End Property
        Public Property xnPreUni As Double '12
            Get
                Return _xnPreUni
            End Get
            Set(ByVal value As Double)
                _xnPreUni = value
            End Set
        End Property
        Public Property xnVlrBas As Double '13
            Get
                Return _xnVlrBas
            End Get
            Set(ByVal value As Double)
                _xnVlrBas = value
            End Set
        End Property
        Public Property xnPorDto As Double '14
            Get
                Return _xnPorDto
            End Get
            Set(ByVal value As Double)
                _xnPorDto = value
            End Set
        End Property
        Public Property xnVlrDto As Double '15
            Get
                Return _xnVlrDto
            End Get
            Set(ByVal value As Double)
                _xnVlrDto = value
            End Set
        End Property
        Public Property xnPreDto As Double '16
            Get
                Return _xnPreDto
            End Get
            Set(ByVal value As Double)
                _xnPreDto = value
            End Set
        End Property
        Public Property xnVlrDtoLin As Double '17
            Get
                Return _xnVlrDtoLin
            End Get
            Set(ByVal value As Double)
                _xnVlrDtoLin = value
            End Set
        End Property
        Public Property xsCodIva As String '18
            Get
                Return _xsCodIva
            End Get
            Set(ByVal value As String)
                _xsCodIva = value
            End Set
        End Property
        Public Property xnPorIva As Double '19
            Get
                Return _xnPorIva
            End Get
            Set(ByVal value As Double)
                _xnPorIva = value
            End Set
        End Property
        Public Property xnVlrIva As Double '20
            Get
                Return _xnVlrIva
            End Get
            Set(ByVal value As Double)
                _xnVlrIva = value
            End Set
        End Property
        Public Property xnVlrIvaLin As Double '21
            Get
                Return _xnVlrIvaLin
            End Get
            Set(ByVal value As Double)
                _xnVlrIvaLin = value
            End Set
        End Property
        Public Property xnPreBru As Double '22
            Get
                Return _xnPreBru
            End Get
            Set(ByVal value As Double)
                _xnPreBru = value
            End Set
        End Property
        Public Property xnTotLin As Double '23
            Get
                Return _xnTotLin
            End Get
            Set(ByVal value As Double)
                _xnTotLin = value
            End Set
        End Property
        Public Property xnPorCms As Double '24
            Get
                Return _xnPorCms
            End Get
            Set(ByVal value As Double)
                _xnPorCms = value
            End Set
        End Property
        Public Property xsCodCco As String '25
            Get
                Return _xsCodCco
            End Get
            Set(ByVal value As String)
                _xsCodCco = value
            End Set
        End Property
        Public Property xsTipLIM As String '26
            Get
                Return _xsTipLIM
            End Get
            Set(ByVal value As String)
                _xsTipLIM = value
            End Set
        End Property
        Public Property xsCodVen As String '27
            Get
                Return _xsCodVen
            End Get
            Set(ByVal value As String)
                _xsCodVen = value
            End Set
        End Property
        Public Property xnLinBas As Long '28
            Get
                Return _xnLinBas
            End Get
            Set(ByVal value As Long)
                _xnLinBas = value
            End Set
        End Property
        Public Property xsCodPdo As String '29
            Get
                Return _xsCodPdo
            End Get
            Set(ByVal value As String)
                _xsCodPdo = value
            End Set
        End Property
        Public Property xsCodCta As String '30
            Get
                Return _xsCodCta
            End Get
            Set(ByVal value As String)
                _xsCodCta = value
            End Set
        End Property
        Public Property xbSolIto As Boolean '31
            Get
                Return _xbSolIto
            End Get
            Set(ByVal value As Boolean)
                _xbSolIto = value
            End Set
        End Property
        Public Property xsCtaCosVta As String '32
            Get
                Return _xsCtaCosVta
            End Get
            Set(ByVal value As String)
                _xsCtaCosVta = value
            End Set
        End Property
        Public Property xbItmBlq As Boolean '33
            Get
                Return _xbItmBlq
            End Get
            Set(ByVal value As Boolean)
                _xbItmBlq = value
            End Set
        End Property
        Public Property xsCodSer As String '34
            Get
                Return _xsCodSer
            End Get
            Set(ByVal value As String)
                _xsCodSer = value
            End Set
        End Property
        Public Property xsClsDoc As String '35
            Get
                Return _xsClsDoc
            End Get
            Set(ByVal value As String)
                _xsClsDoc = value
            End Set
        End Property
        Public Property xnTasCamUsd As Double '36
            Get
                Return _xnTasCamUsd
            End Get
            Set(ByVal value As Double)
                _xnTasCamUsd = value
            End Set
        End Property
        Public Property xnPreUniUsd As Double '37
            Get
                Return _xnPreUniUsd
            End Get
            Set(ByVal value As Double)
                _xnPreUniUsd = value
            End Set
        End Property
        Public Property xnVlrBasUsd As Double '38
            Get
                Return _xnVlrBasUsd
            End Get
            Set(ByVal value As Double)
                _xnVlrBasUsd = value
            End Set
        End Property
        Public Property xsCodRch As String '39
            Get
                Return _xsCodRch
            End Get
            Set(ByVal value As String)
                _xsCodRch = value
            End Set
        End Property
        Public Property xsNroLot As String '40
            Get
                Return _xsNroLot
            End Get
            Set(ByVal value As String)
                _xsNroLot = value
            End Set
        End Property
        Public Property xnSdoCanLin As Double
            Get
                Return _xnSdoCanLin
            End Get
            Set(ByVal value As Double)
                _xnSdoCanLin = value
            End Set
        End Property
        Public Property xnSdoAlm As Double '
            Get
                Return _xnSdoAlm
            End Get
            Set(ByVal value As Double)
                _xnSdoAlm = value
            End Set
        End Property
        Public Property xnSdoInv As Double '
            Get
                Return _xnSdoInv
            End Get
            Set(ByVal value As Double)
                _xnSdoInv = value
            End Set
        End Property
        Public Property xbIndCan As Boolean
            Get
                Return _xbIndCan
            End Get
            Set(ByVal value As Boolean)
                _xbIndCan = value
            End Set
        End Property
        Public Property xbIndCos As Boolean
            Get
                Return _xbIndCos
            End Get
            Set(ByVal value As Boolean)
                _xbIndCos = value
            End Set
        End Property
        Public Property xnUltPreEnt As Double
            Get
                Return _xnUltPreEnt
            End Get
            Set(ByVal value As Double)
                _xnUltPreEnt = value
            End Set
        End Property
        Public Property xnPesProm As Double
            Get
                Return _xnPesProm
            End Get
            Set(ByVal value As Double)
                _xnPesProm = value
            End Set
        End Property
        'Public Property sCodMon As String '3
        '    Get
        '        Return _sCodMon
        '    End Get
        '    Set(ByVal value As String)
        '        _sCodMon = value
        '    End Set
        'End Property
    End Class
#End Region

#Region "Recursos Humanos"
    Public Class eHEDMT
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sNomTer As String '2
        Private _sTipTer As String '3
        Private _sNitTer As String '4
        Private _sDigVer As String '5
        Private _sDirTer As String '6
        Private _sTel1Ter As String '7
        Private _sTel2Ter As String '8
        Private _sTelCll As String '9
        Private _sFax As String '10
        Private _sNomAlt As String '11
        Private _sCodGrpTer As String '12
        Private _sEmlTer As String '13
        Private _sNomCtc As String '14
        Private _sTipCtaCtb As String '15
        Private _sCodCtaCtb As String '16
        Private _sCndPag As String '17
        Private _sCodLstPre As String '18
        Private _nPorDto As Double '19
        Private _nLmtCre As Double '20
        Private _bAct As Boolean '21
        Private _bIna As Boolean '22
        Private _sCmn As String '23
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String '2
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property sTipTer As String '3
            Get
                Return _sTipTer
            End Get
            Set(ByVal value As String)
                _sTipTer = value
            End Set
        End Property
        Public Property sNitTer As String '4
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sDigVer As String '5
            Get
                Return _sDigVer
            End Get
            Set(ByVal value As String)
                _sDigVer = value
            End Set
        End Property
        Public Property sDirTer As String '6
            Get
                Return _sDirTer
            End Get
            Set(ByVal value As String)
                _sDirTer = value
            End Set
        End Property
        Public Property sTel1Ter As String '7
            Get
                Return _sTel1Ter
            End Get
            Set(ByVal value As String)
                _sTel1Ter = value
            End Set
        End Property
        Public Property sTel2Ter As String '8
            Get
                Return _sTel2Ter
            End Get
            Set(ByVal value As String)
                _sTel2Ter = value
            End Set
        End Property
        Public Property sTelCll As String '9
            Get
                Return _sTelCll
            End Get
            Set(ByVal value As String)
                _sTelCll = value
            End Set
        End Property
        Public Property sFax As String '10
            Get
                Return _sFax
            End Get
            Set(ByVal value As String)
                _sFax = value
            End Set
        End Property
        Public Property sNomAlt As String '11
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodGrpTer As String '12
            Get
                Return _sCodGrpTer
            End Get
            Set(ByVal value As String)
                _sCodGrpTer = value
            End Set
        End Property
        Public Property sEmlTer As String '13
            Get
                Return _sEmlTer
            End Get
            Set(ByVal value As String)
                _sEmlTer = value
            End Set
        End Property
        Public Property sNomCtc As String '14
            Get
                Return _sNomCtc
            End Get
            Set(ByVal value As String)
                _sNomCtc = value
            End Set
        End Property
        Public Property sTipCtaCtb As String '15
            Get
                Return _sTipCtaCtb
            End Get
            Set(ByVal value As String)
                _sTipCtaCtb = value
            End Set
        End Property
        Public Property sCodCtaCtb As String '16
            Get
                Return _sCodCtaCtb
            End Get
            Set(ByVal value As String)
                _sCodCtaCtb = value
            End Set
        End Property
        Public Property sCndPag As String '17
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property sCodLstPre As String '18
            Get
                Return _sCodLstPre
            End Get
            Set(ByVal value As String)
                _sCodLstPre = value
            End Set
        End Property
        Public Property nPorDto As Double '19
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property nLmtCre As Double '20
            Get
                Return _nLmtCre
            End Get
            Set(ByVal value As Double)
                _nLmtCre = value
            End Set
        End Property
        Public Property bAct As Boolean '21
            Get
                Return _bAct
            End Get
            Set(ByVal value As Boolean)
                _bAct = value
            End Set
        End Property
        Public Property bIna As Boolean '22
            Get
                Return _bIna
            End Get
            Set(ByVal value As Boolean)
                _bIna = value
            End Set
        End Property
        Public Property sCmn As String '23
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
    End Class
#End Region

#Region "Inventarios"
    Public Class eIEDMI
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodBar As String '2
        Private _sNomItm As String '3
        Private _sNomAlt As String '4
        Private _sClsItm As String '5
        Private _sCodGrp As String '6
        Private _sCodSgr As String '7
        Private _bItmInv As Boolean '8
        Private _bItmVta As Boolean '9
        Private _bItmCom As Boolean '10
        Private _bIndIVA As Boolean '11
        Private _sCodAlt As String '12
        Private _sTipGes As String '13
        Private _bItmAct As Boolean '14
        Private _bItmIna As Boolean '15
        Private _sCodTerPrv As String '16
        Private _sCodTerFte As String '17
        Private _sCodItmFte As String '18
        Private _sUniMedCom As String '19
        Private _nCanUniCom As Integer '20
        Private _sUniEmpCom As String '21
        Private _nCanUniECom As Integer '22
        Private _sCodItoCom As String '23
        Private _sUniMedVta As String '24
        Private _nCanUniVta As Integer '25
        Private _sUniEmpVta As String '26
        Private _nCanUniEVta As Integer '27
        Private _sCodItoVta As String '28
        Private _sCriCtaCbe As String '29
        Private _sUniMedInv As String '30
        Private _sMetVlz As String '31
        Private _nCosItm As Double '32
        Private _sCodAlm As String '33
        Private _nSdoInv As Double '34
        Private _sIvaCom As String '35
        Private _sIvaVta As String '36
        Private _sCodCco As String '37
        Private _sUbiAlm As String '38
        Private _bIndCan As Boolean '39
        Private _bIndCos As Boolean '40
        Private _bIndLibODP As Boolean '41
        Private _nUltPreEnt As Double
        Private _sCodAlmCom As String
        Private _sCodGrpVta As String
        Private _bIndCanRes As Boolean
        Private _bIndCanPry As Boolean

        Private _nSdoIni As Long
        Private _nSdoIniAno As Long
        Private _nCanResODP As Long
        Private _nSdoFinDis As Long
        Private _nCanPedODC As Long
        Private _nSdoFinPry As Long
        Private _nLeadTime As Long
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodBar As String '2
            Get
                Return _sCodBar
            End Get
            Set(ByVal value As String)
                _sCodBar = value
            End Set
        End Property
        Public Property sNomItm As String '3
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String '4
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sClsItm As String '5
            Get
                Return _sClsItm
            End Get
            Set(ByVal value As String)
                _sClsItm = value
            End Set
        End Property
        Public Property sCodGrp As String '6
            Get
                Return _sCodGrp
            End Get
            Set(ByVal value As String)
                _sCodGrp = value
            End Set
        End Property
        Public Property sCodSgr As String '7
            Get
                Return _sCodSgr
            End Get
            Set(ByVal value As String)
                _sCodSgr = value
            End Set
        End Property
        Public Property bItmInv As Boolean '8
            Get
                Return _bItmInv
            End Get
            Set(ByVal value As Boolean)
                _bItmInv = value
            End Set
        End Property
        Public Property bItmVta As Boolean '9
            Get
                Return _bItmVta
            End Get
            Set(ByVal value As Boolean)
                _bItmVta = value
            End Set
        End Property
        Public Property bItmCom As Boolean '10
            Get
                Return _bItmCom
            End Get
            Set(ByVal value As Boolean)
                _bItmCom = value
            End Set
        End Property
        Public Property bIndIVA As Boolean '11
            Get
                Return _bIndIVA
            End Get
            Set(ByVal value As Boolean)
                _bIndIVA = value
            End Set
        End Property
        Public Property sCodAlt As String '12
            Get
                Return _sCodAlt
            End Get
            Set(ByVal value As String)
                _sCodAlt = value
            End Set
        End Property
        Public Property sTipGes As String '13
            Get
                Return _sTipGes
            End Get
            Set(ByVal value As String)
                _sTipGes = value
            End Set
        End Property
        Public Property bItmAct As Boolean '14
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
        Public Property bItmIna As Boolean '15
            Get
                Return _bItmIna
            End Get
            Set(ByVal value As Boolean)
                _bItmIna = value
            End Set
        End Property
        Public Property sCodTerPrv As String '16
            Get
                Return _sCodTerPrv
            End Get
            Set(ByVal value As String)
                _sCodTerPrv = value
            End Set
        End Property
        Public Property sCodTerFte As String '17
            Get
                Return _sCodTerFte
            End Get
            Set(ByVal value As String)
                _sCodTerFte = value
            End Set
        End Property
        Public Property sCodItmFte As String '18
            Get
                Return _sCodItmFte
            End Get
            Set(ByVal value As String)
                _sCodItmFte = value
            End Set
        End Property
        Public Property sUniMedCom As String '19
            Get
                Return _sUniMedCom
            End Get
            Set(ByVal value As String)
                _sUniMedCom = value
            End Set
        End Property
        Public Property nCanUniCom As Integer '20
            Get
                Return _nCanUniCom
            End Get
            Set(ByVal value As Integer)
                _nCanUniCom = value
            End Set
        End Property
        Public Property sUniEmpCom As String '21
            Get
                Return _sUniEmpCom
            End Get
            Set(ByVal value As String)
                _sUniEmpCom = value
            End Set
        End Property
        Public Property nCanUniECom As Integer '22
            Get
                Return _nCanUniECom
            End Get
            Set(ByVal value As Integer)
                _nCanUniECom = value
            End Set
        End Property
        Public Property sCodItoCom As String '23
            Get
                Return _sCodItoCom
            End Get
            Set(ByVal value As String)
                _sCodItoCom = value
            End Set
        End Property
        Public Property sUniMedVta As String '24
            Get
                Return _sUniMedVta
            End Get
            Set(ByVal value As String)
                _sUniMedVta = value
            End Set
        End Property
        Public Property nCanUniVta As Integer '25
            Get
                Return _nCanUniVta
            End Get
            Set(ByVal value As Integer)
                _nCanUniVta = value
            End Set
        End Property
        Public Property sUniEmpVta As String '26
            Get
                Return _sUniEmpVta
            End Get
            Set(ByVal value As String)
                _sUniEmpVta = value
            End Set
        End Property
        Public Property nCanUniEVta As Integer '27
            Get
                Return _nCanUniEVta
            End Get
            Set(ByVal value As Integer)
                _nCanUniEVta = value
            End Set
        End Property
        Public Property sCodItoVta As String '28
            Get
                Return _sCodItoVta
            End Get
            Set(ByVal value As String)
                _sCodItoVta = value
            End Set
        End Property
        Public Property sCriCtaCbe As String '29
            Get
                Return _sCriCtaCbe
            End Get
            Set(ByVal value As String)
                _sCriCtaCbe = value
            End Set
        End Property
        Public Property sUniMedInv As String '30
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sMetVlz As String '31
            Get
                Return _sMetVlz
            End Get
            Set(ByVal value As String)
                _sMetVlz = value
            End Set
        End Property
        Public Property nCosItm As Double '32
            Get
                Return _nCosItm
            End Get
            Set(ByVal value As Double)
                _nCosItm = value
            End Set
        End Property
        Public Property sCodAlm As String '33
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nSdoInv As Double '34
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property sIvaCom As String '35
            Get
                Return _sIvaCom
            End Get
            Set(ByVal value As String)
                _sIvaCom = value
            End Set
        End Property
        Public Property sIvaVta As String '36
            Get
                Return _sIvaVta
            End Get
            Set(ByVal value As String)
                _sIvaVta = value
            End Set
        End Property
        Public Property sCodCco As String '37
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property sUbiAlm As String '38
            Get
                Return _sUbiAlm
            End Get
            Set(ByVal value As String)
                _sUbiAlm = value
            End Set
        End Property
        Public Property bIndCan As Boolean '39
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean '40
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property bIndLibODP As Boolean '41
            Get
                Return _bIndLibODP
            End Get
            Set(ByVal value As Boolean)
                _bIndLibODP = value
            End Set
        End Property
        Public Property nUltPreEnt As Double
            Get
                Return _nUltPreEnt
            End Get
            Set(ByVal value As Double)
                _nUltPreEnt = value
            End Set
        End Property
        Public Property sCodAlmCom As String
            Get
                Return _sCodAlmCom
            End Get
            Set(ByVal value As String)
                _sCodAlmCom = value
            End Set
        End Property
        Public Property sCodGrpVta As String
            Get
                Return _sCodGrpVta
            End Get
            Set(ByVal value As String)
                _sCodGrpVta = value
            End Set
        End Property
        Public Property bIndCanRes As Boolean '8
            Get
                Return _bIndCanRes
            End Get
            Set(ByVal value As Boolean)
                _bIndCanRes = value
            End Set
        End Property
        Public Property bIndCanPry As Boolean '8
            Get
                Return _bIndCanPry
            End Get
            Set(ByVal value As Boolean)
                _bIndCanPry = value
            End Set
        End Property
        Public Property nSdoIni As Long
            Get
                Return _nSdoIni
            End Get
            Set(ByVal value As Long)
                _nSdoIni = value
            End Set
        End Property

        Public Property nSdoIniAno As Long
            Get
                Return _nSdoIniAno
            End Get
            Set(ByVal value As Long)
                _nSdoIniAno = value
            End Set
        End Property

        Public Property nCanResODP As Long
            Get
                Return _nCanResODP
            End Get
            Set(ByVal value As Long)
                _nCanResODP = value
            End Set
        End Property
        Public Property nSdoFinDis As Long
            Get
                Return _nSdoFinDis
            End Get
            Set(ByVal value As Long)
                _nSdoFinDis = value
            End Set
        End Property
        Public Property nCanPedODC As Long
            Get
                Return _nCanPedODC
            End Get
            Set(ByVal value As Long)
                _nCanPedODC = value
            End Set
        End Property
        Public Property nSdoFinPry As Long
            Get
                Return _nSdoFinPry
            End Get
            Set(ByVal value As Long)
                _nSdoFinPry = value
            End Set
        End Property
        Public Property nLeadTime As Long
            Get
                Return _nLeadTime
            End Get
            Set(ByVal value As Long)
                _nLeadTime = value
            End Set
        End Property


    End Class
    Public Class eILDMI1
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodAlm As String '2
        Private _nCanMin As Double '3
        Private _nCanMax As Double '4
        Private _nOrdMin As Double '5
        Private _nSdoAlm As Double '6
        Private _nPreUni As Double '7
        Private _nVlrTot As Double '8
        Private _nUltPreEnt As Double
        Private _sCtaInv As String '9
        Private _sCtaCosVta As String '10
        Private _sCtaTrs As String '11
        Private _sCtaIng As String '12
        Private _sCtaDevVta As String ' 13
        Private _sCtaVrc As String '14
        Private _sCtaGto As String '15
        Private _sCtaDot As String '16
        Private _sCtaDifPre As String '17
        Private _sCtaRev As String '18
        Private _sCtaAumInv As String '19
        Private _sCtaRedInv As String '20
        Private _sCtaCom As String '21
        Private _sCtaDevCom As String '22
        Private _sCtaWIP As String '23
        Private _nSdoIniAlm As Double
        Private _nSdoIniAnoAlm As Double
        Private _nCanResODPAlm As Double
        Private _nSdoFinDisAlm As Double

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodAlm As String '2
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nCanMin As Double '3
            Get
                Return _nCanMin
            End Get
            Set(ByVal value As Double)
                _nCanMin = value
            End Set
        End Property
        Public Property nCanMax As Double '4
            Get
                Return _nCanMax
            End Get
            Set(ByVal value As Double)
                _nCanMax = value
            End Set
        End Property
        Public Property nOrdMin As Double '5
            Get
                Return _nOrdMin
            End Get
            Set(ByVal value As Double)
                _nOrdMin = value
            End Set
        End Property
        Public Property nSdoAlm As Double '6
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property nPreUni As Double '7
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nVlrTot As Double '8
            Get
                Return _nVlrTot
            End Get
            Set(ByVal value As Double)
                _nVlrTot = value
            End Set
        End Property
        Public Property nUltPreEnt As Double
            Get
                Return _nUltPreEnt
            End Get
            Set(ByVal value As Double)
                _nUltPreEnt = value
            End Set
        End Property
        Public Property sCtaInv As String '9
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
        Public Property sCtaCosVta As String '10
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property sCtaTrs As String '11
            Get
                Return _sCtaTrs
            End Get
            Set(ByVal value As String)
                _sCtaTrs = value
            End Set
        End Property
        Public Property sCtaIng As String '12
            Get
                Return _sCtaIng
            End Get
            Set(ByVal value As String)
                _sCtaIng = value
            End Set
        End Property
        Public Property sCtaDevVta As String '13
            Get
                Return _sCtaDevVta
            End Get
            Set(ByVal value As String)
                _sCtaDevVta = value
            End Set
        End Property
        Public Property sCtaVrc As String '14
            Get
                Return _sCtaVrc
            End Get
            Set(ByVal value As String)
                _sCtaVrc = value
            End Set
        End Property
        Public Property sCtaGto As String '15
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
            End Set
        End Property
        Public Property sCtaDot As String '16
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String '17
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaRev As String '18
            Get
                Return _sCtaRev
            End Get
            Set(ByVal value As String)
                _sCtaRev = value
            End Set
        End Property
        Public Property sCtaAumInv As String '19
            Get
                Return _sCtaAumInv
            End Get
            Set(ByVal value As String)
                _sCtaAumInv = value
            End Set
        End Property
        Public Property sCtaRedInv As String '20
            Get
                Return _sCtaRedInv
            End Get
            Set(ByVal value As String)
                _sCtaRedInv = value
            End Set
        End Property
        Public Property sCtaCom As String '21
            Get
                Return _sCtaCom
            End Get
            Set(ByVal value As String)
                _sCtaCom = value
            End Set
        End Property
        Public Property sCtaDevCom As String '22
            Get
                Return _sCtaDevCom
            End Get
            Set(ByVal value As String)
                _sCtaDevCom = value
            End Set
        End Property
        Public Property sCtaWIP As String '23
            Get
                Return _sCtaWIP
            End Get
            Set(ByVal value As String)
                _sCtaWIP = value
            End Set
        End Property
        Public Property nSdoIniAlm As Double '6
            Get
                Return _nSdoIniAlm
            End Get
            Set(ByVal value As Double)
                _nSdoIniAlm = value
            End Set
        End Property
        Public Property nSdoIniAnoAlm As Double '6
            Get
                Return _nSdoIniAnoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoIniAnoAlm = value
            End Set
        End Property
        Public Property nCanResODPAlm As Double '6
            Get
                Return _nCanResODPAlm
            End Get
            Set(ByVal value As Double)
                _nCanResODPAlm = value
            End Set
        End Property
        Public Property nSdoFinDisAlm As Double '6
            Get
                Return _nSdoFinDisAlm
            End Get
            Set(ByVal value As Double)
                _nSdoFinDisAlm = value
            End Set
        End Property

    End Class
    Public Class eIELDMI1
        Private _eIEDMI As New eIEDMI '0
        Private _eILDMI1 As New eILDMI1 '1
        Public Property eIEDMI As eIEDMI
            Get
                Return _eIEDMI
            End Get
            Set(ByVal value As eIEDMI)
                _eIEDMI = value
            End Set
        End Property
        Public Property eILDMI1 As eILDMI1
            Get
                Return _eILDMI1
            End Get
            Set(ByVal value As eILDMI1)
                _eILDMI1 = value
            End Set
        End Property
    End Class
    Public Class eIELDMI1_Rpt
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodBar As String '2
        Private _sNomItm As String '3
        Private _sNomAlt As String '4
        Private _sClsItm As String '5
        Private _sCodGrp As String '6
        Private _sCodSgr As String '7
        Private _bItmInv As Boolean '8
        Private _bItmVta As Boolean '9
        Private _bItmCom As Boolean '10
        Private _bIndIVA As Boolean '11
        Private _sCodAlt As String '12
        Private _sTipGes As String '13
        Private _bItmAct As Boolean '14
        Private _bItmIna As Boolean '15
        Private _sCodTerPrv As String '16
        Private _sCodTerFte As String '17
        Private _sCodItmFte As String '18
        Private _sUniMedCom As String '19
        Private _nCanUniCom As Integer '20
        Private _sUniEmpCom As String '21
        Private _nCanUniECom As Integer '22
        Private _sCodItoCom As String '23
        Private _sUniMedVta As String '24
        Private _nCanUniVta As Integer '25
        Private _sUniEmpVta As String '26
        Private _nCanUniEVta As Integer '27
        Private _sCodItoVta As String '28
        Private _sCriCtaCbe As String '29
        Private _sUniMedInv As String '30
        Private _sMetVlz As String '31
        Private _nCosItm As Double '32
        Private _sCodAlm As String '33
        Private _nSdoInv As Double '34
        Private _sIvaCom As String '35
        Private _sIvaVta As String '36
        Private _sCodCco As String '37
        Private _sUbiAlm As String '38
        Private _bIndCan As Boolean '39
        Private _bIndCos As Boolean '40
        Private _bIndLibODP As Boolean '41
        Private _nUltPreEnt As Double '42
        Private _sCodAlmCom As String
        Private _sCodGrpVta As String
        Private _bIndCanRes As Boolean
        Private _bIndCanPry As Boolean
        Private _nSdoIni As Double
        Private _nSdoIniAno As Double
        Private _nCanResODP As Double
        Private _nSdoFinDis As Double
        Private _nCanPedODC As Double
        Private _nSdoFinPry As Double
        Private _nLeadTime As Double


        Private _xnId As Long '0
        Private _xsCodItm As String '1
        Private _xsCodAlm As String '2
        Private _xnCanMin As Double '3
        Private _xnCanMax As Double '4
        Private _xnOrdMin As Double '5
        Private _xnSdoAlm As Double '6
        Private _xnPreUni As Double '7
        Private _xnVlrTot As Double '8
        Private _xnUltPreEnt As Double '9
        Private _xsCtaInv As String '10
        Private _xsCtaCosVta As String '
        Private _xsCtaTrs As String '
        Private _xsCtaIng As String '
        Private _xsCtaDevVta As String ' 
        Private _xsCtaVrc As String '15
        Private _xsCtaGto As String '
        Private _xsCtaDot As String '
        Private _xsCtaDifPre As String '
        Private _xsCtaRev As String '
        Private _xsCtaAumInv As String '20
        Private _xsCtaRedInv As String '
        Private _xsCtaCom As String '
        Private _xsCtaDevCom As String '
        Private _xsCtaWIP As String '24
        Private _xnSdoIniAlm As Double
        Private _xnSdoIniAnoAlm As Double
        Private _xnCanResODPAlm As Double
        Private _xnSdoFinDisAlm As Double

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodBar As String '2
            Get
                Return _sCodBar
            End Get
            Set(ByVal value As String)
                _sCodBar = value
            End Set
        End Property
        Public Property sNomItm As String '3
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String '4
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sClsItm As String '5
            Get
                Return _sClsItm
            End Get
            Set(ByVal value As String)
                _sClsItm = value
            End Set
        End Property
        Public Property sCodGrp As String '6
            Get
                Return _sCodGrp
            End Get
            Set(ByVal value As String)
                _sCodGrp = value
            End Set
        End Property
        Public Property sCodSgr As String '7
            Get
                Return _sCodSgr
            End Get
            Set(ByVal value As String)
                _sCodSgr = value
            End Set
        End Property
        Public Property bItmInv As Boolean '8
            Get
                Return _bItmInv
            End Get
            Set(ByVal value As Boolean)
                _bItmInv = value
            End Set
        End Property
        Public Property bItmVta As Boolean '9
            Get
                Return _bItmVta
            End Get
            Set(ByVal value As Boolean)
                _bItmVta = value
            End Set
        End Property
        Public Property bItmCom As Boolean '10
            Get
                Return _bItmCom
            End Get
            Set(ByVal value As Boolean)
                _bItmCom = value
            End Set
        End Property
        Public Property bIndIVA As Boolean '11
            Get
                Return _bIndIVA
            End Get
            Set(ByVal value As Boolean)
                _bIndIVA = value
            End Set
        End Property
        Public Property sCodAlt As String '12
            Get
                Return _sCodAlt
            End Get
            Set(ByVal value As String)
                _sCodAlt = value
            End Set
        End Property
        Public Property sTipGes As String '13
            Get
                Return _sTipGes
            End Get
            Set(ByVal value As String)
                _sTipGes = value
            End Set
        End Property
        Public Property bItmAct As Boolean '14
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
        Public Property bItmIna As Boolean '15
            Get
                Return _bItmIna
            End Get
            Set(ByVal value As Boolean)
                _bItmIna = value
            End Set
        End Property
        Public Property sCodTerPrv As String '16
            Get
                Return _sCodTerPrv
            End Get
            Set(ByVal value As String)
                _sCodTerPrv = value
            End Set
        End Property
        Public Property sCodTerFte As String '17
            Get
                Return _sCodTerFte
            End Get
            Set(ByVal value As String)
                _sCodTerFte = value
            End Set
        End Property
        Public Property sCodItmFte As String '18
            Get
                Return _sCodItmFte
            End Get
            Set(ByVal value As String)
                _sCodItmFte = value
            End Set
        End Property
        Public Property sUniMedCom As String '19
            Get
                Return _sUniMedCom
            End Get
            Set(ByVal value As String)
                _sUniMedCom = value
            End Set
        End Property
        Public Property nCanUniCom As Integer '20
            Get
                Return _nCanUniCom
            End Get
            Set(ByVal value As Integer)
                _nCanUniCom = value
            End Set
        End Property
        Public Property sUniEmpCom As String '21
            Get
                Return _sUniEmpCom
            End Get
            Set(ByVal value As String)
                _sUniEmpCom = value
            End Set
        End Property
        Public Property nCanUniECom As Integer '22
            Get
                Return _nCanUniECom
            End Get
            Set(ByVal value As Integer)
                _nCanUniECom = value
            End Set
        End Property
        Public Property sCodItoCom As String '23
            Get
                Return _sCodItoCom
            End Get
            Set(ByVal value As String)
                _sCodItoCom = value
            End Set
        End Property
        Public Property sUniMedVta As String '24
            Get
                Return _sUniMedVta
            End Get
            Set(ByVal value As String)
                _sUniMedVta = value
            End Set
        End Property
        Public Property nCanUniVta As Integer '25
            Get
                Return _nCanUniVta
            End Get
            Set(ByVal value As Integer)
                _nCanUniVta = value
            End Set
        End Property
        Public Property sUniEmpVta As String '26
            Get
                Return _sUniEmpVta
            End Get
            Set(ByVal value As String)
                _sUniEmpVta = value
            End Set
        End Property
        Public Property nCanUniEVta As Integer '27
            Get
                Return _nCanUniEVta
            End Get
            Set(ByVal value As Integer)
                _nCanUniEVta = value
            End Set
        End Property
        Public Property sCodItoVta As String '28
            Get
                Return _sCodItoVta
            End Get
            Set(ByVal value As String)
                _sCodItoVta = value
            End Set
        End Property
        Public Property sCriCtaCbe As String '29
            Get
                Return _sCriCtaCbe
            End Get
            Set(ByVal value As String)
                _sCriCtaCbe = value
            End Set
        End Property
        Public Property sUniMedInv As String '30
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sMetVlz As String '31
            Get
                Return _sMetVlz
            End Get
            Set(ByVal value As String)
                _sMetVlz = value
            End Set
        End Property
        Public Property nCosItm As Double '32
            Get
                Return _nCosItm
            End Get
            Set(ByVal value As Double)
                _nCosItm = value
            End Set
        End Property
        Public Property sCodAlm As String '33
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nSdoInv As Double '34
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property sIvaCom As String '35
            Get
                Return _sIvaCom
            End Get
            Set(ByVal value As String)
                _sIvaCom = value
            End Set
        End Property
        Public Property sIvaVta As String '36
            Get
                Return _sIvaVta
            End Get
            Set(ByVal value As String)
                _sIvaVta = value
            End Set
        End Property
        Public Property sCodCco As String '37
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property sUbiAlm As String '38
            Get
                Return _sUbiAlm
            End Get
            Set(ByVal value As String)
                _sUbiAlm = value
            End Set
        End Property
        Public Property bIndCan As Boolean '39
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean '40
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property bIndLibODP As Boolean '41
            Get
                Return _bIndLibODP
            End Get
            Set(ByVal value As Boolean)
                _bIndLibODP = value
            End Set
        End Property
        Public Property nUltPreEnt As Double
            Get
                Return _nUltPreEnt
            End Get
            Set(ByVal value As Double)
                _nUltPreEnt = value
            End Set
        End Property
        Public Property sCodAlmCom As String '38
            Get
                Return _sCodAlmCom
            End Get
            Set(ByVal value As String)
                _sCodAlmCom = value
            End Set
        End Property

        Public Property sCodGrpVta As String '38
            Get
                Return _sCodGrpVta
            End Get
            Set(ByVal value As String)
                _sCodGrpVta = value
            End Set
        End Property

        Public Property bIndCanRes As Boolean '41
            Get
                Return _bIndCanRes
            End Get
            Set(ByVal value As Boolean)
                _bIndCanRes = value
            End Set
        End Property
        Public Property bIndCanPry As Boolean '41
            Get
                Return _bIndCanPry
            End Get
            Set(ByVal value As Boolean)
                _bIndCanPry = value
            End Set
        End Property

        Public Property nSdoIni As Double
            Get
                Return _nSdoIni
            End Get
            Set(ByVal value As Double)
                _nSdoIni = value
            End Set
        End Property
        Public Property nSdoIniAno As Double
            Get
                Return _nSdoIniAno
            End Get
            Set(ByVal value As Double)
                _nSdoIniAno = value
            End Set
        End Property
        Public Property nCanResODP As Double
            Get
                Return _nCanResODP
            End Get
            Set(ByVal value As Double)
                _nCanResODP = value
            End Set
        End Property
        Public Property nSdoFinDis As Double
            Get
                Return _nSdoFinDis
            End Get
            Set(ByVal value As Double)
                _nSdoFinDis = value
            End Set
        End Property
        Public Property nCanPedODC As Double
            Get
                Return _nCanPedODC
            End Get
            Set(ByVal value As Double)
                _nCanPedODC = value
            End Set
        End Property
        Public Property nSdoFinPry As Double
            Get
                Return _nSdoFinPry
            End Get
            Set(ByVal value As Double)
                _nSdoFinPry = value
            End Set
        End Property
        Public Property nLeadTime As Double
            Get
                Return _nLeadTime
            End Get
            Set(ByVal value As Double)
                _nLeadTime = value
            End Set
        End Property




        Public Property xnId As Long '0
            Get
                Return _xnId
            End Get
            Set(ByVal value As Long)
                _xnId = value
            End Set
        End Property
        Public Property xsCodItm As String '1
            Get
                Return _xsCodItm
            End Get
            Set(ByVal value As String)
                _xsCodItm = value
            End Set
        End Property
        Public Property xsCodAlm As String '2
            Get
                Return _xsCodAlm
            End Get
            Set(ByVal value As String)
                _xsCodAlm = value
            End Set
        End Property
        Public Property xnCanMin As Double '3
            Get
                Return _xnCanMin
            End Get
            Set(ByVal value As Double)
                _xnCanMin = value
            End Set
        End Property
        Public Property xnCanMax As Double '4
            Get
                Return _xnCanMax
            End Get
            Set(ByVal value As Double)
                _xnCanMax = value
            End Set
        End Property
        Public Property xnOrdMin As Double '5
            Get
                Return _xnOrdMin
            End Get
            Set(ByVal value As Double)
                _xnOrdMin = value
            End Set
        End Property
        Public Property xnSdoAlm As Double '6
            Get
                Return _xnSdoAlm
            End Get
            Set(ByVal value As Double)
                _xnSdoAlm = value
            End Set
        End Property
        Public Property xnPreUni As Double '7
            Get
                Return _xnPreUni
            End Get
            Set(ByVal value As Double)
                _xnPreUni = value
            End Set
        End Property
        Public Property xnVlrTot As Double '8
            Get
                Return _xnVlrTot
            End Get
            Set(ByVal value As Double)
                _xnVlrTot = value
            End Set
        End Property
        Public Property xnUltPreEnt As Double
            Get
                Return _xnUltPreEnt
            End Get
            Set(ByVal value As Double)
                _xnUltPreEnt = value
            End Set
        End Property
        Public Property xsCtaInv As String '9
            Get
                Return _xsCtaInv
            End Get
            Set(ByVal value As String)
                _xsCtaInv = value
            End Set
        End Property
        Public Property xsCtaCosVta As String '10
            Get
                Return _xsCtaCosVta
            End Get
            Set(ByVal value As String)
                _xsCtaCosVta = value
            End Set
        End Property
        Public Property xsCtaTrs As String '11
            Get
                Return _xsCtaTrs
            End Get
            Set(ByVal value As String)
                _xsCtaTrs = value
            End Set
        End Property
        Public Property xsCtaIng As String '12
            Get
                Return _xsCtaIng
            End Get
            Set(ByVal value As String)
                _xsCtaIng = value
            End Set
        End Property
        Public Property xsCtaDevVta As String '13
            Get
                Return _xsCtaDevVta
            End Get
            Set(ByVal value As String)
                _xsCtaDevVta = value
            End Set
        End Property
        Public Property xsCtaVrc As String '14
            Get
                Return _xsCtaVrc
            End Get
            Set(ByVal value As String)
                _xsCtaVrc = value
            End Set
        End Property
        Public Property xsCtaGto As String '15
            Get
                Return _xsCtaGto
            End Get
            Set(ByVal value As String)
                _xsCtaGto = value
            End Set
        End Property
        Public Property xsCtaDot As String '16
            Get
                Return _xsCtaDot
            End Get
            Set(ByVal value As String)
                _xsCtaDot = value
            End Set
        End Property
        Public Property xsCtaDifPre As String '17
            Get
                Return _xsCtaDifPre
            End Get
            Set(ByVal value As String)
                _xsCtaDifPre = value
            End Set
        End Property
        Public Property xsCtaRev As String '18
            Get
                Return _xsCtaRev
            End Get
            Set(ByVal value As String)
                _xsCtaRev = value
            End Set
        End Property
        Public Property xsCtaAumInv As String '19
            Get
                Return _xsCtaAumInv
            End Get
            Set(ByVal value As String)
                _xsCtaAumInv = value
            End Set
        End Property
        Public Property xsCtaRedInv As String '20
            Get
                Return _xsCtaRedInv
            End Get
            Set(ByVal value As String)
                _xsCtaRedInv = value
            End Set
        End Property
        Public Property xsCtaCom As String '21
            Get
                Return _xsCtaCom
            End Get
            Set(ByVal value As String)
                _xsCtaCom = value
            End Set
        End Property
        Public Property xsCtaDevCom As String '22
            Get
                Return _xsCtaDevCom
            End Get
            Set(ByVal value As String)
                _xsCtaDevCom = value
            End Set
        End Property
        Public Property xsCtaWIP As String '23
            Get
                Return _xsCtaWIP
            End Get
            Set(ByVal value As String)
                _xsCtaWIP = value
            End Set
        End Property
        Public Property xnSdoIniAlm As Double
            Get
                Return _xnSdoIniAlm
            End Get
            Set(ByVal value As Double)
                _xnSdoIniAlm = value
            End Set
        End Property
        Public Property xnSdoIniAnoAlm As Double
            Get
                Return _xnSdoIniAnoAlm
            End Get
            Set(ByVal value As Double)
                _xnSdoIniAnoAlm = value
            End Set
        End Property
        Public Property xnCanResODPAlm As Double
            Get
                Return _xnCanResODPAlm
            End Get
            Set(ByVal value As Double)
                _xnCanResODPAlm = value
            End Set
        End Property
        Public Property xnSdoFinDisAlm As Double
            Get
                Return _xnSdoFinDisAlm
            End Get
            Set(ByVal value As Double)
                _xnSdoFinDisAlm = value
            End Set
        End Property
    End Class
    Public Class eILDMI2
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodTer As String '2
        Private _sCodLstPre As String '3
        Private _nUltPreCom As Double '4 
        Private _bTerDfl As Boolean '5
        ' Private _sNomItm As String '6
        ' Private _sNomAlt As String '7

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodTer As String '2
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sCodLstPre As String '3
            Get
                Return _sCodLstPre
            End Get
            Set(ByVal value As String)
                _sCodLstPre = value
            End Set
        End Property
        Public Property nUltPreCom As Double '4
            Get
                Return _nUltPreCom
            End Get
            Set(ByVal value As Double)
                _nUltPreCom = value
            End Set
        End Property
        Public Property bTerDfl As Boolean '5
            Get
                Return _bTerDfl
            End Get
            Set(ByVal value As Boolean)
                _bTerDfl = value
            End Set
        End Property
        'Public Property sNomItm As String '6
        '    Get
        '        Return _sNomItm
        '    End Get
        '    Set(ByVal value As String)
        '        _sNomItm = value
        '    End Set
        'End Property
        '
        '        Public Property sNomAlt As String '7
        '            Get
        '                Return _sNomAlt
        '            End Get
        '            Set(ByVal value As String)
        '                _sNomAlt = value
        '           End Set
        '        End Property
    End Class
    Public Class eIEREV
        Private _nID As Long       '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long
        Private _sCodSer As String
        Private _sCodTra As String
        Private _sEstDoc As String '5
        Private _sTipRev As String
        Private _dFecCtb As Date
        Private _dFecDoc As Date
        Private _dFecVto As Date
        Private _dFecSys As Date   '10
        Private _sDocRef As String '11
        Private _nTotDoc As Double
        Private _sClsDoc As String
        Private _sCmn As String
        Private _sCodCteCtb As String '15
        Private _nNroCtectb As Long
        Private _nIdFECCT As Long
        Private _sCodMon As String
        Private _sCodUsr As String
        Private _sCodAut As String
        Public Property nID As Long '0
            Get
                Return _nID
            End Get
            Set(ByVal value As Long)
                _nID = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sEstDoc As String '3
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property sCodSer As String '4
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodTra As String '5
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property sTipRev As String
            Get
                Return _sTipRev
            End Get
            Set(ByVal value As String)
                _sTipRev = value
            End Set
        End Property
        Public Property dFecCtb As Date
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '10
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sDocRef As String
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotDoc As Double
            Get
                Return _nTotDoc
            End Get
            Set(ByVal value As Double)
                _nTotDoc = value
            End Set
        End Property
     
        Public Property sClsDoc As String
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
      
    
        Public Property sCmn As String
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sCodCteCtb As String
            Get
                Return _sCodCteCtb
            End Get
            Set(ByVal value As String)
                _sCodCteCtb = value
            End Set
        End Property
        Public Property nNroCteCtb As Long
            Get
                Return _nNroCtectb
            End Get
            Set(ByVal value As Long)
                _nNroCtectb = value
            End Set
        End Property
        Public Property nIdFECCT As Long
            Get
                Return _nIdFECCT
            End Get
            Set(ByVal value As Long)
                _nIdFECCT = value
            End Set
        End Property
      
        Public Property sCodMon As String
            Get
                Return _sCodMon
            End Get
            Set(ByVal value As String)
                _sCodMon = value
            End Set
        End Property
        Public Property sCodUsr As String
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sCodAut As String '20
            Get
                Return _sCodAut
            End Get
            Set(ByVal value As String)
                _sCodAut = value
            End Set
        End Property
    End Class
    Public Class eILREV1
        Private _nId As Long '0
        Private _sCodDoc As String
        Private _nNroDoc As Long
        Private _sCodSer As String
        Private _sTipRev As String
        Private _sCodItm As String '5
        Private _sNomItm As String
        Private _sNomAlt As String '
        Private _sCodAlm As String '
        Private _nCanItm As Double ' 
        Private _sUniMedInv As String '10
        Private _nPreUni As Double
        Private _nPreAnt As Double
        Private _nDifPre As Double
        Private _nTotLin As Double
        Private _sCodPdo As String '15
        Private _sCodCta As String '
        Private _sCtaCosVta As String
        Private _sCtaAumInv As String
        Private _sCtaRedInv As String
        Private _sClsDoc As String '20

        'Adicionales
        Private _nSdoAlm As Double
        Private _nSdoInv As Double
        Private _bIndCan As Boolean
        Private _bIndCos As Boolean
        Private _nUltPreEnt As Double
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipRev As String
            Get
                Return _sTipRev
            End Get
            Set(ByVal value As String)
                _sTipRev = value
            End Set
        End Property
        Public Property sCodItm As String '5
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sNomItm As String '
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String '
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodAlm As String '
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nCanItm As Double '
            Get
                Return _nCanItm
            End Get
            Set(ByVal value As Double)
                _nCanItm = value
            End Set
        End Property
        Public Property sUniMedInv As String '10
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nPreUni As Double '
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nPreant As Double '
            Get
                Return _nPreAnt
            End Get
            Set(ByVal value As Double)
                _nPreAnt = value
            End Set
        End Property
        Public Property nDifPre As Double '
            Get
                Return _nDifPre
            End Get
            Set(ByVal value As Double)
                _nDifPre = value
            End Set
        End Property
        Public Property nTotLin As Double '
            Get
                Return _nTotLin
            End Get
            Set(ByVal value As Double)
                _nTotLin = value
            End Set
        End Property
        Public Property sCodPdo As String '15
            Get
                Return _sCodPdo
            End Get
            Set(ByVal value As String)
                _sCodPdo = value
            End Set
        End Property
        Public Property sCtaCosVta As String '
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property sCtaAumInv As String '
            Get
                Return _sCtaAumInv
            End Get
            Set(ByVal value As String)
                _sCtaAumInv = value
            End Set
        End Property
        Public Property sCtaRedInv As String '
            Get
                Return _sCtaRedInv
            End Get
            Set(ByVal value As String)
                _sCtaRedInv = value
            End Set
        End Property
        Public Property sCodCta As String '
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property

        Public Property sClsDoc As String '35
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property

        Public Property nSdoAlm As Double
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property nSdoInv As Double
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property bIndCan As Boolean
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property nUltPreEnt As Double
            Get
                Return _nUltPreEnt
            End Get
            Set(ByVal value As Double)
                _nUltPreEnt = value
            End Set
        End Property
    End Class
    Public Class Q1_eILDMI2
        Private _eILDMI2 As New eILDMI2 '0
        Private _sNomItm As String '1
        Private _sNomAlt As String '2
        Public Property eILDMI2 As eILDMI2 '0
            Get
                Return _eILDMI2
            End Get
            Set(ByVal value As eILDMI2)
                _eILDMI2 = value
            End Set
        End Property
        Public Property sNomItm As String '1
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String '2
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
    End Class
    Public Class Qry_eILDMI2
        Private _eILDMI2 As New eILDMI2 '0
        Private _sNomTer As String '1
        Public Property eILDMI2 As eILDMI2 '0
            Get
                Return _eILDMI2
            End Get
            Set(ByVal value As eILDMI2)
                _eILDMI2 = value
            End Set
        End Property
        Public Property sNomTer As String '1
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
    End Class
    Public Class eSdoAlm
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodAlm As String '2
        Private _nCanMin As Double '3
        Private _nCanMax As Double '4
        Private _nOrdMin As Double '5
        Private _nSdoAlm As Double '6
        Private _nPreUni As Double '7
        Private _nVlrTot As Double '8
        Private _sCtaInv As String '9
        Private _sCtaCosVta As String '10
        Private _sCtaTrs As String '11
        Private _sCtaIng As String '12
        Private _sCtaDevVta As String ' 13
        Private _sCtaVrc As String '14
        Private _sCtaGto As String '15
        Private _sCtaDot As String '16
        Private _sCtaDifPre As String '17
        Private _sCtaRev As String '18
        Private _sCtaAumInv As String '19
        Private _sCtaRedInv As String '20
        Private _sCtaCom As String '21
        Private _sCtaDevCom As String '22
        Private _sCtaWIP As String '23
        Private _nId1 As Long '24
        Private _sCodAlm1 As String '25
        Private _sNomAlm1 As String '26
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodAlm As String '2
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nCanMin As Double '3
            Get
                Return _nCanMin
            End Get
            Set(ByVal value As Double)
                _nCanMin = value
            End Set
        End Property
        Public Property nCanMax As Double '4
            Get
                Return _nCanMax
            End Get
            Set(ByVal value As Double)
                _nCanMax = value
            End Set
        End Property
        Public Property nOrdMin As Double '5
            Get
                Return _nOrdMin
            End Get
            Set(ByVal value As Double)
                _nOrdMin = value
            End Set
        End Property
        Public Property nSdoAlm As Double '6
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property nPreUni As Double '7
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nVlrTot As Double '8
            Get
                Return _nVlrTot
            End Get
            Set(ByVal value As Double)
                _nVlrTot = value
            End Set
        End Property
        Public Property sCtaInv As String '9
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
        Public Property sCtaCosVta As String '10
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property sCtaTrs As String '11
            Get
                Return _sCtaTrs
            End Get
            Set(ByVal value As String)
                _sCtaTrs = value
            End Set
        End Property
        Public Property sCtaIng As String '12
            Get
                Return _sCtaIng
            End Get
            Set(ByVal value As String)
                _sCtaIng = value
            End Set
        End Property
        Public Property sCtaDevVta As String '13
            Get
                Return _sCtaDevVta
            End Get
            Set(ByVal value As String)
                _sCtaDevVta = value
            End Set
        End Property
        Public Property sCtaVrc As String '14
            Get
                Return _sCtaVrc
            End Get
            Set(ByVal value As String)
                _sCtaVrc = value
            End Set
        End Property
        Public Property sCtaGto As String '15
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
            End Set
        End Property
        Public Property sCtaDot As String '16
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String '17
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaRev As String '18
            Get
                Return _sCtaRev
            End Get
            Set(ByVal value As String)
                _sCtaRev = value
            End Set
        End Property
        Public Property sCtaAumInv As String '19
            Get
                Return _sCtaAumInv
            End Get
            Set(ByVal value As String)
                _sCtaAumInv = value
            End Set
        End Property
        Public Property sCtaRedInv As String '20
            Get
                Return _sCtaRedInv
            End Get
            Set(ByVal value As String)
                _sCtaRedInv = value
            End Set
        End Property
        Public Property sCtaCom As String '21
            Get
                Return _sCtaCom
            End Get
            Set(ByVal value As String)
                _sCtaCom = value
            End Set
        End Property
        Public Property sCtaDevCom As String '22
            Get
                Return _sCtaDevCom
            End Get
            Set(ByVal value As String)
                _sCtaDevCom = value
            End Set
        End Property
        Public Property sCtaWIP As String '23
            Get
                Return _sCtaWIP
            End Get
            Set(ByVal value As String)
                _sCtaWIP = value
            End Set
        End Property

        Public Property nId1 As Long '24
            Get
                Return _nId1
            End Get
            Set(ByVal value As Long)
                _nId1 = value
            End Set
        End Property
        Public Property sCodAlm1 As String '25
            Get
                Return _sCodAlm1
            End Get
            Set(ByVal value As String)
                _sCodAlm1 = value
            End Set
        End Property
        Public Property sNomAlm1 As String '26
            Get
                Return _sNomAlm1
            End Get
            Set(ByVal value As String)
                _sNomAlm1 = value
            End Set
        End Property
    End Class
    Public Class eDgvMOV1
        Private _eGLMOV1 As eGLMOV1 '0
        Private _eIELDMI1 As eIELDMI1 '1
        Private _sCtaGto As String '2
        Private _sCtaIng As String '3
        Private _sCtaDot As String '4
        Private _sCtaDifPre As String '5
        Private _sCtaDsv As String '6
        Private _sCtaDev As String '7
        Private _sCtaRev As String '8
        Public Property eGLMOV1 As eGLMOV1 '0
            Get
                Return _eGLMOV1
            End Get
            Set(ByVal value As eGLMOV1)
                _eGLMOV1 = value
            End Set
        End Property
        Public Property eIELDMI1 As eIELDMI1 '1
            Get
                Return _eIELDMI1
            End Get
            Set(ByVal value As eIELDMI1)
                _eIELDMI1 = value
            End Set
        End Property
        Public Property sCtaGto As String '7
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
            End Set
        End Property
        Public Property sCtaIng As String '8
            Get
                Return _sCtaIng
            End Get
            Set(ByVal value As String)
                _sCtaIng = value
            End Set
        End Property
        Public Property sCtaDot As String '9
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String '10
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaDsv As String '11
            Get
                Return _sCtaDsv
            End Get
            Set(ByVal value As String)
                _sCtaDsv = value
            End Set
        End Property
        Public Property sCtaDev As String '12
            Get
                Return _sCtaDev
            End Get
            Set(ByVal value As String)
                _sCtaDev = value
            End Set
        End Property
        Public Property sCtaRev As String '13
            Get
                Return _sCtaRev
            End Get
            Set(ByVal value As String)
                _sCtaRev = value
            End Set
        End Property
    End Class
    Public Class eKARDEX
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sNomItm As String '
        Private _sNomAlt As String '
        Private _sCodGrp As String '
        Private _sUniMedInv As String '
        Private _dFecDoc As Date
        Private _sTipMov As String
        Private _sCodDoc As String
        Private _nNroDoc As Long
        Private _sCodSer As String '10
        Private _sCodTra As String
        Private _sDocRef As String
        Private _sCodDocBas As String
        Private _sCodSerBas As String
        Private _nNroDocBas As Long
        Private _sCodAlm As String
        Private _nCanItm As Double
        Private _nPreUni As Double
        Private _nTotLin As Double '18
        Private _sCmn As String
        Private _nCanItmEnt As Double
        Private _nTotLinEnt As Double
        Private _nCanItmSal As Double
        Private _nTotLinSal As Double
        Private _nCanItmSdo As Double
        Private _nTotLinSdo As Double
        Private _dFecDocIni As Date
        Private _dFecDocFin As Date
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sNomItm As String '
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String '
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodGrp As String '
            Get
                Return _sCodGrp
            End Get
            Set(ByVal value As String)
                _sCodGrp = value
            End Set
        End Property
        Public Property sUniMedInv As String '
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property dFecDoc As Date
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property sTipMov As String
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sCodDoc As String '
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '10
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodTra As String '
            Get
                Return _sCodTra
            End Get
            Set(ByVal value As String)
                _sCodTra = value
            End Set
        End Property
        Public Property sDocRef As String '
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property sCodDocBas As String
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property sCodSerBas As String
            Get
                Return _sCodSerBas
            End Get
            Set(ByVal value As String)
                _sCodSerBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCodAlm As String
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nCanItm As Double
            Get
                Return _nCanItm
            End Get
            Set(ByVal value As Double)
                _nCanItm = value
            End Set
        End Property
        Public Property nPreUni As Double
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nTotLin As Double '18
            Get
                Return _nTotLin
            End Get
            Set(ByVal value As Double)
                _nTotLin = value
            End Set
        End Property
        Public Property sCmn As String '
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property nCanItmEnt As Double
            Get
                Return _nCanItmEnt
            End Get
            Set(ByVal value As Double)
                _nCanItmEnt = value
            End Set
        End Property
        Public Property nTotLinEnt As Double
            Get
                Return _nTotLinEnt
            End Get
            Set(ByVal value As Double)
                _nTotLinEnt = value
            End Set
        End Property
        Public Property nCanItmSal As Double
            Get
                Return _nCanItmSal
            End Get
            Set(ByVal value As Double)
                _nCanItmSal = value
            End Set
        End Property
        Public Property nTotLinSal As Double
            Get
                Return _nTotLinSal
            End Get
            Set(ByVal value As Double)
                _nTotLinSal = value
            End Set
        End Property
        Public Property nCanItmSdo As Double
            Get
                Return _nCanItmSdo
            End Get
            Set(ByVal value As Double)
                _nCanItmSdo = value
            End Set
        End Property
        Public Property nTotLinSdo As Double
            Get
                Return _nTotLinSdo
            End Get
            Set(ByVal value As Double)
                _nTotLinSdo = value
            End Set
        End Property
        Public Property dFecDocIni As Date
            Get
                Return _dFecDocIni
            End Get
            Set(ByVal value As Date)
                _dFecDocIni = value
            End Set
        End Property
        Public Property dFecDocFin As Date
            Get
                Return _dFecDocFin
            End Get
            Set(ByVal value As Date)
                _dFecDocFin = value
            End Set
        End Property
    End Class
#End Region

#Region "Producción"
    Public Class ePEFOM
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sNomItm As String '2
        Private _nCanLotStn As Double '3
        Private _sUniMedStn As String '4
        Private _nCanUniStn As Double '5
        Private _sUniMedInv As String '6
        Private _sTipLIM As String '7
        Private _sCodAlm As String '8
        Private _nPesItm As Double '9
        Private _nPorItm As Double '10
        Private _nTieItm As Double '11
        Private _nCIFItm As Double '12
        Private _nVlrItm As Double '13
        Private _bRegAci As Boolean '14
        Private _sRegSan As String '15
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sNomItm As String '2
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property nCanLotStn As Double '3
            Get
                Return _nCanLotStn
            End Get
            Set(ByVal value As Double)
                _nCanLotStn = value
            End Set
        End Property
        Public Property sUniMedStn As String '4
            Get
                Return _sUniMedStn
            End Get
            Set(ByVal value As String)
                _sUniMedStn = value
            End Set
        End Property
        Public Property nCanUniStn As Double '5
            Get
                Return _nCanUniStn
            End Get
            Set(ByVal value As Double)
                _nCanUniStn = value
            End Set
        End Property
        Public Property sUniMedInv As String '6
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sTipLIM As String '7
            Get
                Return _sTipLIM
            End Get
            Set(ByVal value As String)
                _sTipLIM = value
            End Set
        End Property
        Public Property sCodAlm As String '8
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nPesItm As Double '9
            Get
                Return _nPesItm
            End Get
            Set(ByVal value As Double)
                _nPesItm = value
            End Set
        End Property
        Public Property nPorItm As Double '10
            Get
                Return _nPorItm
            End Get
            Set(ByVal value As Double)
                _nPorItm = value
            End Set
        End Property
        Public Property nTieItm As Double
            Get
                Return _nTieItm
            End Get
            Set(ByVal value As Double)
                _nTieItm = value
            End Set
        End Property
        Public Property nCIFItm As Double
            Get
                Return _nCIFItm
            End Get
            Set(ByVal value As Double)
                _nCIFItm = value
            End Set
        End Property
        Public Property nVlrItm As Double '13
            Get
                Return _nVlrItm
            End Get
            Set(ByVal value As Double)
                _nVlrItm = value
            End Set
        End Property
        Public Property bRegAci As Boolean '14
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
        Public Property sRegSan As String '15
            Get
                Return _sRegSan
            End Get
            Set(ByVal value As String)
                _sRegSan = value
            End Set
        End Property
    End Class
    Public Class ePLFOM1
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodCmt As String '2
        Private _nCanCmt As Double '3
        Private _nPesCmt As Double '4
        Private _nPorCmt As Double '5
        Private _nPreUni As Double '6
        Private _sCodAlmCns As String '7
        Private _sUniMedInv As String '8
        Private _sTipCmt As String '9
        Private _sCodCmtAlt As String '10
        Private _bItmAct As String '11
        Private _bIndCan As Boolean '12
        Private _bIndCos As Boolean '13
        Private _sNomCmt As String '14
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCmt As String '2
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property nCanCmt As Double '3
            Get
                Return _nCanCmt
            End Get
            Set(ByVal value As Double)
                _nCanCmt = value
            End Set
        End Property
        Public Property nPesCmt As Double '4
            Get
                Return _nPesCmt
            End Get
            Set(ByVal value As Double)
                _nPesCmt = value
            End Set
        End Property
        Public Property nPorCmt As Double '5
            Get
                Return _nPorCmt
            End Get
            Set(ByVal value As Double)
                _nPorCmt = value
            End Set
        End Property
        Public Property nPreUni As Double '6
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property sCodAlmCns As String '7
            Get
                Return _sCodAlmCns
            End Get
            Set(ByVal value As String)
                _sCodAlmCns = value
            End Set
        End Property
        Public Property sUniMedInv As String '8
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sTipCmt As String '9
            Get
                Return _sTipCmt
            End Get
            Set(ByVal value As String)
                _sTipCmt = value
            End Set
        End Property
        Public Property sCodCmtAlt As String '10
            Get
                Return _sCodCmtAlt
            End Get
            Set(ByVal value As String)
                _sCodCmtAlt = value
            End Set
        End Property
        Public Property bItmAct As Boolean '11
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
        Public Property bIndCan As Boolean '12
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean '13
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property sNomCmt As String
            Get
                Return _sNomCmt
            End Get
            Set(ByVal value As String)
                _sNomCmt = value
            End Set
        End Property
    End Class
    Public Class ePLFOM2
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _nPosOpe As Long '2
        Private _sCodOpe As String '3
        Private _sCodCtr As String '4
        Private _nTieOpe As Double '5
        Private _nPorOpe As Double
        Private _nPreUni As Double
        Private _nCanBasPro As Double
        Private _nTotTieOpe As Double
        Private _bItmAct As Boolean '10
        Public Property nId As Long '
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nPosOpe As Long '2
            Get
                Return _nPosOpe
            End Get
            Set(ByVal value As Long)
                _nPosOpe = value
            End Set
        End Property
        Public Property sCodOpe As String '3
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property sCodCtr As String '4
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nTieOpe As Double '5
            Get
                Return _nTieOpe
            End Get
            Set(ByVal value As Double)
                _nTieOpe = value
            End Set
        End Property
        Public Property nPorOpe As Double
            Get
                Return _nPorOpe
            End Get
            Set(ByVal value As Double)
                _nPorOpe = value
            End Set
        End Property
        Public Property nPreUni As Double
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nCanBasPro As Double
            Get
                Return _nCanBasPro
            End Get
            Set(ByVal value As Double)
                _nCanBasPro = value
            End Set
        End Property
        Public Property nTotTieOpe As Double
            Get
                Return _nTotTieOpe
            End Get
            Set(ByVal value As Double)
                _nTotTieOpe = value
            End Set
        End Property
        Public Property bItmAct As Boolean '10
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
    End Class
    Public Class ePLFOM3
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodCIF As String '2
        Private _sCodCtr As String '3
        Private _nVlrCIFRea As Double '4
        Private _nTasCIF As Double '5
        Private _nPreUni As Double '6
        Private _bItmAct As Boolean '7
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCIF As String '2
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property sCodCtr As String '3
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nVlrCIFRea As Double '4
            Get
                Return _nVlrCIFRea
            End Get
            Set(ByVal value As Double)
                _nVlrCIFRea = value
            End Set
        End Property
        Public Property nTasCIF As Double '5
            Get
                Return _nTasCIF
            End Get
            Set(ByVal value As Double)
                _nTasCIF = value
            End Set
        End Property
        Public Property nPreUni As Double '6
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property bItmAct As Boolean '7
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
    End Class
    Public Class ePLFOM5
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodAna As String '2
        Private _sDesAna As String '3
        Private _sCodTipAna As String '4
        Private _bItmAct As Boolean '5
        Private _sNomAna As String '
        Private _sNomTipAna As String '

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodAna As String '2
            Get
                Return _sCodAna
            End Get
            Set(ByVal value As String)
                _sCodAna = value
            End Set
        End Property
        Public Property sDesAna As String '3
            Get
                Return _sDesAna
            End Get
            Set(ByVal value As String)
                _sDesAna = value
            End Set
        End Property
        Public Property sCodTipAna As String '4
            Get
                Return _sCodTipAna
            End Get
            Set(ByVal value As String)
                _sCodTipAna = value
            End Set
        End Property
        Public Property bItmAct As Boolean '5
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
        Public Property sNomAna As String
            Get
                Return _sNomAna
            End Get
            Set(ByVal value As String)
                _sNomAna = value
            End Set
        End Property
        Public Property sNomTipAna As String
            Get
                Return _sNomTipAna
            End Get
            Set(ByVal value As String)
                _sNomTipAna = value
            End Set
        End Property
    End Class
    Public Class ePELIM
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sNomItm As String '2
        Private _nCanLotStn As Double '3
        Private _sUniMedStn As String '4
        Private _nCanUniStn As Double '5
        Private _sUniMedInv As String '6
        Private _sTipLIM As String '7
        Private _sCodAlm As String '8
        Private _nPesItm As Double '9
        Private _nPorItm As Double '10
        Private _nTieItm As Double '11
        Private _nCIFItm As Double '12
        Private _nVlrItm As Double '13
        Private _bRegAci As Boolean '14
        Private _sRegSan As String '15
        Private _nPreVta As Double '16
        Private _bIndCanRes As Boolean
        Private _bIndCanPry As Boolean

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sNomItm As String '2
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property nCanLotStn As Double '3
            Get
                Return _nCanLotStn
            End Get
            Set(ByVal value As Double)
                _nCanLotStn = value
            End Set
        End Property
        Public Property sUniMedStn As String '4
            Get
                Return _sUniMedStn
            End Get
            Set(ByVal value As String)
                _sUniMedStn = value
            End Set
        End Property
        Public Property nCanUniStn As Double '5
            Get
                Return _nCanUniStn
            End Get
            Set(ByVal value As Double)
                _nCanUniStn = value
            End Set
        End Property
        Public Property sUniMedInv As String '6
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sTipLIM As String '7
            Get
                Return _sTipLIM
            End Get
            Set(ByVal value As String)
                _sTipLIM = value
            End Set
        End Property
        Public Property sCodAlm As String '8
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nPesItm As Double '9
            Get
                Return _nPesItm
            End Get
            Set(ByVal value As Double)
                _nPesItm = value
            End Set
        End Property
        Public Property nPorItm As Double '10
            Get
                Return _nPorItm
            End Get
            Set(ByVal value As Double)
                _nPorItm = value
            End Set
        End Property
        Public Property nTieItm As Double
            Get
                Return _nTieItm
            End Get
            Set(ByVal value As Double)
                _nTieItm = value
            End Set
        End Property
        Public Property nCIFItm As Double
            Get
                Return _nCIFItm
            End Get
            Set(ByVal value As Double)
                _nCIFItm = value
            End Set
        End Property
        Public Property nVlrItm As Double '13
            Get
                Return _nVlrItm
            End Get
            Set(ByVal value As Double)
                _nVlrItm = value
            End Set
        End Property
        Public Property bRegAci As Boolean '14
            Get
                Return _bRegAci
            End Get
            Set(ByVal value As Boolean)
                _bRegAci = value
            End Set
        End Property
        Public Property sRegSan As String '15
            Get
                Return _sRegSan
            End Get
            Set(ByVal value As String)
                _sRegSan = value
            End Set
        End Property
        Public Property nPreVta As Double '16
            Get
                Return _nPreVta
            End Get
            Set(ByVal value As Double)
                _nPreVta = value
            End Set
        End Property
        Public Property bIndCanRes As Boolean '11
            Get
                Return _bIndCanRes
            End Get
            Set(ByVal value As Boolean)
                _bIndCanRes = value
            End Set
        End Property
        Public Property bIndCanPry As Boolean '11
            Get
                Return _bIndCanPry
            End Get
            Set(ByVal value As Boolean)
                _bIndCanPry = value
            End Set
        End Property
    End Class
    Public Class ePLLIM1
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodCmt As String '2
        Private _nCanCmt As Double '3
        Private _nPesCmt As Double '4
        Private _nPorCmt As Double '5
        Private _nPreUni As Double '6
        Private _sCodAlmCns As String '7
        Private _sUniMedInv As String '8
        Private _sTipCmt As String '9
        Private _sCodCmtAlt As String '10
        Private _bItmAct As Boolean '11
        Private _sNomCmt As String '14
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCmt As String '2
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property nCanCmt As Double '3
            Get
                Return _nCanCmt
            End Get
            Set(ByVal value As Double)
                _nCanCmt = value
            End Set
        End Property
        Public Property nPesCmt As Double '4
            Get
                Return _nPesCmt
            End Get
            Set(ByVal value As Double)
                _nPesCmt = value
            End Set
        End Property
        Public Property nPorCmt As Double '5
            Get
                Return _nPorCmt
            End Get
            Set(ByVal value As Double)
                _nPorCmt = value
            End Set
        End Property
        Public Property nPreUni As Double '6
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property sCodAlmCns As String '7
            Get
                Return _sCodAlmCns
            End Get
            Set(ByVal value As String)
                _sCodAlmCns = value
            End Set
        End Property
        Public Property sUniMedInv As String '8
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sTipCmt As String '9
            Get
                Return _sTipCmt
            End Get
            Set(ByVal value As String)
                _sTipCmt = value
            End Set
        End Property
        Public Property sCodCmtAlt As String '10
            Get
                Return _sCodCmtAlt
            End Get
            Set(ByVal value As String)
                _sCodCmtAlt = value
            End Set
        End Property
        Public Property bItmAct As Boolean '11
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
        Public Property sNomCmt As String
            Get
                Return _sNomCmt
            End Get
            Set(ByVal value As String)
                _sNomCmt = value
            End Set
        End Property

    End Class
    Public Class ePLLIM2
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _nPosOpe As Long '2
        Private _sCodOpe As String '3
        Private _sCodCtr As String '4
        Private _nTieOpe As Double '5
        Private _nPorOpe As Double
        Private _nPreUni As Double
        Private _nCanBasPro As Double
        Private _nTotTieOpe As Double
        Private _bItmAct As Boolean '10
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nPosOpe As Long '2
            Get
                Return _nPosOpe
            End Get
            Set(ByVal value As Long)
                _nPosOpe = value
            End Set
        End Property
        Public Property sCodOpe As String '3
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property sCodCtr As String '4
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nTieOpe As Double '5
            Get
                Return _nTieOpe
            End Get
            Set(ByVal value As Double)
                _nTieOpe = value
            End Set
        End Property
        Public Property nPorOpe As Double
            Get
                Return _nPorOpe
            End Get
            Set(ByVal value As Double)
                _nPorOpe = value
            End Set
        End Property
        Public Property nPreUni As Double
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nCanBasPro As Double
            Get
                Return _nCanBasPro
            End Get
            Set(ByVal value As Double)
                _nCanBasPro = value
            End Set
        End Property
        Public Property nTotTieOpe As Double
            Get
                Return _nTotTieOpe
            End Get
            Set(ByVal value As Double)
                _nTotTieOpe = value
            End Set
        End Property
        Public Property bItmAct As Boolean '10
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
    End Class
    Public Class ePLLIM3
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodCIF As String '2
        Private _sCodCtr As String '3
        Private _nVlrCIFRea As Double '4
        Private _nTasCIF As Double '5
        Private _bItmAct As Boolean '6
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCIF As String '2
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property sCodCtr As String '3
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nVlrCIFRea As Double '4
            Get
                Return _nVlrCIFRea
            End Get
            Set(ByVal value As Double)
                _nVlrCIFRea = value
            End Set
        End Property
        Public Property nTasCIF As Double '5
            Get
                Return _nTasCIF
            End Get
            Set(ByVal value As Double)
                _nTasCIF = value
            End Set
        End Property
        Public Property bItmAct As Boolean '6
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
    End Class
    Public Class ePLLIM4
        Private _nId As Long '0
        Private _sCodItm As String '1
        Private _sCodCmt As String '2
        Private _nCanCmt As Double '3
        Private _nPesCmt As Double '4
        Private _nPorCmt As Double '5
        Private _nPreUni As Double '6
        Private _sCodAlmCns As String '7
        Private _sUniMedInv As String '8
        Private _sTipCmt As String '9
        Private _sCodCmtAlt As String '10
        Private _bItmAct As Boolean '11
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodItm As String '1
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCmt As String '2
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property nCanCmt As Double '3
            Get
                Return _nCanCmt
            End Get
            Set(ByVal value As Double)
                _nCanCmt = value
            End Set
        End Property
        Public Property nPesCmt As Double '4
            Get
                Return _nPesCmt
            End Get
            Set(ByVal value As Double)
                _nPesCmt = value
            End Set
        End Property
        Public Property nPorCmt As Double '5
            Get
                Return _nPorCmt
            End Get
            Set(ByVal value As Double)
                _nPorCmt = value
            End Set
        End Property
        Public Property nPreUni As Double '6
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property sCodAlmCns As String '7
            Get
                Return _sCodAlmCns
            End Get
            Set(ByVal value As String)
                _sCodAlmCns = value
            End Set
        End Property
        Public Property sUniMedInv As String '8
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property sTipCmt As String '9
            Get
                Return _sTipCmt
            End Get
            Set(ByVal value As String)
                _sTipCmt = value
            End Set
        End Property
        Public Property sCodCmtAlt As String '10
            Get
                Return _sCodCmtAlt
            End Get
            Set(ByVal value As String)
                _sCodCmtAlt = value
            End Set
        End Property
        Public Property bItmAct As Boolean '11
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
    End Class
    Public Class eQ_PQFOM1
        Private _nId As Long '0
        Private _sCodCmt As String '
        Private _sNomCmt As String '
        Private _bItmAct As String '
        Private _sCodLIM As String '
        Private _sNomLIM As String '5
        Private _sCodFOM As String '
        Private _sNomFOM As String '
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCmt As String '
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property sNomCmt As String '
            Get
                Return _sNomCmt
            End Get
            Set(ByVal value As String)
                _sNomCmt = value
            End Set
        End Property
        Public Property bItmAct As Boolean '
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property

        Public Property sCodLIM As String '
            Get
                Return _sCodLIM
            End Get
            Set(ByVal value As String)
                _sCodLIM = value
            End Set
        End Property
        Public Property sNomLIM As String '5
            Get
                Return _sNomLIM
            End Get
            Set(ByVal value As String)
                _sNomLIM = value
            End Set
        End Property

        Public Property sCodFOM As String '
            Get
                Return _sCodFOM
            End Get
            Set(ByVal value As String)
                _sCodFOM = value
            End Set
        End Property
        Public Property sNomFOM As String '5
            Get
                Return _sNomFOM
            End Get
            Set(ByVal value As String)
                _sNomFOM = value
            End Set
        End Property



    End Class
    Public Class eQ_PQLIM1
        Private _nId As Long '0
        Private _sCodCmt As String '
        Private _sNomCmt As String '
        Private _bItmAct As String '
        Private _sCodLIM As String '
        Private _sNomLIM As String '5
      
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodCmt As String '
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property sNomCmt As String '
            Get
                Return _sNomCmt
            End Get
            Set(ByVal value As String)
                _sNomCmt = value
            End Set
        End Property
        Public Property bItmAct As Boolean '
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property

        Public Property sCodLIM As String '
            Get
                Return _sCodLIM
            End Get
            Set(ByVal value As String)
                _sCodLIM = value
            End Set
        End Property
        Public Property sNomLIM As String '5
            Get
                Return _sNomLIM
            End Get
            Set(ByVal value As String)
                _sNomLIM = value
            End Set
        End Property

    End Class
    Public Class Q_ePELIM_eIEDMI
        Private _ePELIM As New ePELIM
        Private _sNomItm As String
        Private _sNomAlt As String
        Public Property ePELIM As ePELIM '0
            Get
                Return _ePELIM
            End Get
            Set(ByVal value As ePELIM)
                _ePELIM = value
            End Set
        End Property
        Public Property sNomItm As String '1
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property sNomAlt As String '1
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property

    End Class
    Public Class ePEODP
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sNroLot As String '4
        Private _sEstOdp As String '5
        Private _sCodItm As String '6
        Private _sNomItm As String '7
        Private _nCanLotStn As Double
        Private _sUniMedStn As String '
        Private _nCanUniStn As Double '10
        Private _nCanOdp As Double '11
        Private _sUniMedOdp As String '
        Private _nCanUniOdp As Double '
        Private _sUniMedInv As String '
        Private _nCanUniEdp As Double '15
        Private _nTieItm As Double '
        Private _nTotTieOdp As Double '
        Private _nTotTieEdp As Double '
        Private _sCodAlm As String '
        Private _dFecEmi As Date '20
        Private _dFecIni As Date '
        Private _dFecFin As Date '
        Private _dFecSys As Date ' 
        Private _sClsDoc As String '
        Private _sCodUsr As String '25
        Private _sRegSan As String '26
        Private _sCmn As String
        Private _bIndCanRes As Boolean
        Private _bIndCanPry As Boolean

        Private _nSdoInv As Double
        Private _nPreUni As Double
        Private _nSdoAlm As Double
        Private _sCtaInv As String
        Private _bIndCan As Boolean
        Private _bIndCos As Boolean
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sNroLot As String '4
            Get
                Return _sNroLot
            End Get
            Set(ByVal value As String)
                _sNroLot = value
            End Set
        End Property
        Public Property sEstOdp As String '5
            Get
                Return _sEstOdp
            End Get
            Set(ByVal value As String)
                _sEstOdp = value
            End Set
        End Property
        Public Property sCodItm As String '7
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nCanLotStn As Double '7
            Get
                Return _nCanLotStn
            End Get
            Set(ByVal value As Double)
                _nCanLotStn = value
            End Set
        End Property
        Public Property sUniMedStn As String '8
            Get
                Return _sUniMedStn
            End Get
            Set(ByVal value As String)
                _sUniMedStn = value
            End Set
        End Property
        Public Property nCanUniStn As Double '9
            Get
                Return _nCanUniStn
            End Get
            Set(ByVal value As Double)
                _nCanUniStn = value
            End Set
        End Property
        Public Property nCanOdp As Double '10
            Get
                Return _nCanOdp
            End Get
            Set(ByVal value As Double)
                _nCanOdp = value
            End Set
        End Property
        Public Property sUniMedOdp As String '11
            Get
                Return _sUniMedOdp
            End Get
            Set(ByVal value As String)
                _sUniMedOdp = value
            End Set
        End Property
        Public Property nCanUniOdp As Double '12
            Get
                Return _nCanUniOdp
            End Get
            Set(ByVal value As Double)
                _nCanUniOdp = value
            End Set
        End Property
        Public Property sUniMedInv As String '13
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nCanUniEdp As Double '14
            Get
                Return _nCanUniEdp
            End Get
            Set(ByVal value As Double)
                _nCanUniEdp = value
            End Set
        End Property
        Public Property nTieItm As Double '15
            Get
                Return _nTieItm
            End Get
            Set(ByVal value As Double)
                _nTieItm = value
            End Set
        End Property
        Public Property nTotTieOdp As Double '16
            Get
                Return _nTotTieOdp
            End Get
            Set(ByVal value As Double)
                _nTotTieOdp = value
            End Set
        End Property
        Public Property nTotTieEdp As Double '17
            Get
                Return _nTotTieEdp
            End Get
            Set(ByVal value As Double)
                _nTotTieEdp = value
            End Set
        End Property
        Public Property sCodAlm As String '18
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property dFecEmi As Date '19
            Get
                Return _dFecEmi
            End Get
            Set(ByVal value As Date)
                _dFecEmi = value
            End Set
        End Property
        Public Property dFecIni As Date '20
            Get
                Return _dFecIni
            End Get
            Set(ByVal value As Date)
                _dFecIni = value
            End Set
        End Property
        Public Property dFecFin As Date '21
            Get
                Return _dFecFin
            End Get
            Set(ByVal value As Date)
                _dFecFin = value
            End Set
        End Property
        Public Property dFecSys As Date '22
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sClsDoc As String '23
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCodUsr As String '24
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sRegSan As String '15
            Get
                Return _sRegSan
            End Get
            Set(ByVal value As String)
                _sRegSan = value
            End Set
        End Property
        Public Property sCmn As String '
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property bIndCanRes As Boolean '30
            Get
                Return _bIndCanRes
            End Get
            Set(ByVal value As Boolean)
                _bIndCanRes = value
            End Set
        End Property
        Public Property bIndCanPry As Boolean '30
            Get
                Return _bIndCanPry
            End Get
            Set(ByVal value As Boolean)
                _bIndCanPry = value
            End Set
        End Property

        Public Property sNomItm As String '25
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property nSdoInv As Double '26
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property nPreUni As Double '27
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nSdoAlm As Double '28
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property sCtaInv As String '29
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
        Public Property bIndCan As Boolean '30
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean '31
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
    End Class
    Public Class ePLODP1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sCodItm As String '4
        Private _sCodCmt As String '5
        Private _sUniMedInv As String '6
        Private _nCanCmt As Double '7
        Private _nCanReq As Double '8
        Private _nCanCns As Double '9
        Private _nPreUni As Double '10
        Private _nVlrTotReq As Double '11
        Private _nVlrTotCns As Double '12
        Private _sCodAlmCns As String '13
        Private _sCodCmtAlt As String '14
        Private _nVrcCan As Double
        Private _nPorVrnCan As Double
        Private _nVlrVrcCan As Double '17
        'Campos externos
        Private _sNomCmt As String '18
        Private _nSdoInv As Double
        Private _nSdoAlm As Double
        Private _sCtaInv As String
        Private _bIndCan As Boolean
        Private _bIndCos As Boolean '23
        Private _sCodGrp As String '24
        Private _bIndLibODP As Boolean '25
        Private _sUniMedInvIEDMI As String '26
        Private _nIdPEROP As Long
        Private _bIndCanRes As Boolean
        Private _bIndCanPry As Boolean
        Private _nCanResODP As Double
        Private _nCanResODPAlm As Double
        Private _nSdoFinDis As Double
        Private _nSdoFinDisAlm As Double
        Private _nCanPedODC As Double
        Private _nSdoFinPry As Double

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property nIdPEROP As Long '0
            Get
                Return _nIdPEROP
            End Get
            Set(ByVal value As Long)
                _nIdPEROP = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodItm As String '4
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCmt As String '5
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property sUniMedInv As String '6
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nCanCmt As Double '7
            Get
                Return _nCanCmt
            End Get
            Set(ByVal value As Double)
                _nCanCmt = value
            End Set
        End Property
        Public Property nCanReq As Double '8
            Get
                Return _nCanReq
            End Get
            Set(ByVal value As Double)
                _nCanReq = value
            End Set
        End Property
        Public Property nCanCns As Double '9
            Get
                Return _nCanCns
            End Get
            Set(ByVal value As Double)
                _nCanCns = value
            End Set
        End Property
        Public Property nPreUni As Double '10
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nVlrTotReq As Long '11
            Get
                Return _nVlrTotReq
            End Get
            Set(ByVal value As Long)
                _nVlrTotReq = value
            End Set
        End Property
        Public Property nVlrTotCns As Long '12
            Get
                Return _nVlrTotCns
            End Get
            Set(ByVal value As Long)
                _nVlrTotCns = value
            End Set
        End Property
        Public Property sCodAlmCns As String '13
            Get
                Return _sCodAlmCns
            End Get
            Set(ByVal value As String)
                _sCodAlmCns = value
            End Set
        End Property
        Public Property sCodCmtAlt As String '14
            Get
                Return _sCodCmtAlt
            End Get
            Set(ByVal value As String)
                _sCodCmtAlt = value
            End Set
        End Property
        Public Property nVrcCan As Double '15
            Get
                Return _nVrcCan
            End Get
            Set(ByVal value As Double)
                _nVrcCan = value
            End Set
        End Property
        Public Property nPorVrnCan As Double
            Get
                Return _nPorVrnCan
            End Get
            Set(ByVal value As Double)
                _nPorVrnCan = value
            End Set
        End Property
        Public Property nVlrVrcCan As Double '17
            Get
                Return _nVlrVrcCan
            End Get
            Set(ByVal value As Double)
                _nVlrVrcCan = value
            End Set
        End Property

        Public Property sNomCmt As String '18
            Get
                Return _sNomCmt
            End Get
            Set(ByVal value As String)
                _sNomCmt = value
            End Set
        End Property
        Public Property nSdoInv As Double
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property nSdoAlm As Double
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property sCtaInv As String
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
        Public Property bIndCan As Boolean
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean '23
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property sCodGrp As String
            Get
                Return _sCodGrp
            End Get
            Set(ByVal value As String)
                _sCodGrp = value
            End Set
        End Property
        Public Property bIndLibODP As Boolean '25
            Get
                Return _bIndLibODP
            End Get
            Set(ByVal value As Boolean)
                _bIndLibODP = value
            End Set
        End Property
        Public Property sUniMedInvIEDMI As String '26
            Get
                Return _sUniMedInvIEDMI
            End Get
            Set(ByVal value As String)
                _sUniMedInvIEDMI = value
            End Set
        End Property
        Public Property bIndCanRes As Boolean
            Get
                Return _bIndCanRes
            End Get
            Set(ByVal value As Boolean)
                _bIndCanRes = value
            End Set
        End Property
        Public Property bIndCanPry As Boolean
            Get
                Return _bIndCanPry
            End Get
            Set(ByVal value As Boolean)
                _bIndCanPry = value
            End Set
        End Property

        Public Property nCanResODP As Double
            Get
                Return _nCanResODP
            End Get
            Set(ByVal value As Double)
                _nCanResODP = value
            End Set
        End Property
        Public Property nCanResODPAlm As Double
            Get
                Return _nCanResODPAlm
            End Get
            Set(ByVal value As Double)
                _nCanResODPAlm = value
            End Set
        End Property
        Public Property nSdoFinDis As Double
            Get
                Return _nSdoFinDis
            End Get
            Set(ByVal value As Double)
                _nSdoFinDis = value
            End Set
        End Property
        Public Property nSdoFinDisAlm As Double
            Get
                Return _nSdoFinDisAlm
            End Get
            Set(ByVal value As Double)
                _nSdoFinDisAlm = value
            End Set
        End Property
        Public Property nCanPedODC As Double
            Get
                Return _nCanPedODC
            End Get
            Set(ByVal value As Double)
                _nCanPedODC = value
            End Set
        End Property
        Public Property nSdoFinPry As Double
            Get
                Return _nSdoFinPry
            End Get
            Set(ByVal value As Double)
                _nSdoFinPry = value
            End Set
        End Property

    End Class
    Public Class ePLODP2
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sCodItm As String '4
        Private _nPosOpe As Long '5
        Private _sCodOpe As String '6
        Private _sCodCtr As String '7
        Private _nTieOpe As Double '8
        Private _nTieReq As Double '9
        Private _nTieCns As Double '10
        Private _nPreUni As Double
        Private _nVlrTotReq As Double
        Private _nVlrTotCns As Double
        Private _nPorOpeReq As Double
        Private _nPorOpeCns As Double
        Private _nVrcPorOpe As Double '16
        Private _sNomOpe As String '17
        Private _sNomCtr As String '18
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodItm As String '4
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nPosOpe As Long '5
            Get
                Return _nPosOpe
            End Get
            Set(ByVal value As Long)
                _nPosOpe = value
            End Set
        End Property
        Public Property sCodOpe As String '6
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property sCodCtr As String '7
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nTieOpe As Double '8
            Get
                Return _nTieOpe
            End Get
            Set(ByVal value As Double)
                _nTieOpe = value
            End Set
        End Property
        Public Property nTieReq As Double '9
            Get
                Return _nTieReq
            End Get
            Set(ByVal value As Double)
                _nTieReq = value
            End Set
        End Property
        Public Property nTieCns As Double '10
            Get
                Return _nTieCns
            End Get
            Set(ByVal value As Double)
                _nTieCns = value
            End Set
        End Property
        Public Property nPreUni As Double '11
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nVlrTotReq As Double '12
            Get
                Return _nVlrTotReq
            End Get
            Set(ByVal value As Double)
                _nVlrTotReq = value
            End Set
        End Property
        Public Property nVlrTotCns As Double '13
            Get
                Return _nVlrTotCns
            End Get
            Set(ByVal value As Double)
                _nVlrTotCns = value
            End Set
        End Property
        Public Property nPorOpeReq As Double '14
            Get
                Return _nPorOpeReq
            End Get
            Set(ByVal value As Double)
                _nPorOpeReq = value
            End Set
        End Property
        Public Property nPorOpeCns As Double
            Get
                Return _nPorOpeCns
            End Get
            Set(ByVal value As Double)
                _nPorOpeCns = value
            End Set
        End Property
        Public Property nVrcPorOpe As Double '16
            Get
                Return _nVrcPorOpe
            End Get
            Set(ByVal value As Double)
                _nVrcPorOpe = value
            End Set
        End Property
        Public Property sNomOpe As String '17
            Get
                Return _sNomOpe
            End Get
            Set(ByVal value As String)
                _sNomOpe = value
            End Set
        End Property
        Public Property sNomCtr As String '18
            Get
                Return _sNomCtr
            End Get
            Set(ByVal value As String)
                _sNomCtr = value
            End Set
        End Property
    End Class
    Public Class ePLODP3
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sCodItm As String '4
        Private _sCodCIF As String '5
        Private _sCodCtr As String '6
        Private _nVlrCIFRea As Double '7
        Private _nVlrReq As Double '8
        Private _nVlrCns As Double '9
        Private _nTasCIF As Double '10
        Private _nVlrTotReq As Double '11
        Private _nVlrTotCns As Double '12
        Private _nVrcCIF As Double
        Private _nPorVrcCIF As Double
        Private _nVlrVrcCIF As Double '15   

        Private _sNomCIF As String '16

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodItm As String '4
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCIF As String '5
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property sCodCtr As String '6
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nVlrCIFRea As Double '7
            Get
                Return _nVlrCIFRea
            End Get
            Set(ByVal value As Double)
                _nVlrCIFRea = value
            End Set
        End Property
        Public Property nVlrReq As Double '8
            Get
                Return _nVlrReq
            End Get
            Set(ByVal value As Double)
                _nVlrReq = value
            End Set
        End Property
        Public Property nVlrCns As Double '9
            Get
                Return _nVlrCns
            End Get
            Set(ByVal value As Double)
                _nVlrCns = value
            End Set
        End Property
        Public Property nTasCIF As Double '10
            Get
                Return _nTasCIF
            End Get
            Set(ByVal value As Double)
                _nTasCIF = value
            End Set
        End Property
        Public Property nVlrTotReq As Double '11
            Get
                Return _nVlrTotReq
            End Get
            Set(ByVal value As Double)
                _nVlrTotReq = value
            End Set
        End Property
        Public Property nVlrTotCns As Double '12
            Get
                Return _nVlrTotCns
            End Get
            Set(ByVal value As Double)
                _nVlrTotCns = value
            End Set
        End Property
        Public Property nVrcCIF As Double '
            Get
                Return _nVrcCIF
            End Get
            Set(ByVal value As Double)
                _nVrcCIF = value
            End Set
        End Property
        Public Property nPorVrcCIF As Double
            Get
                Return _nPorVrcCIF
            End Get
            Set(ByVal value As Double)
                _nPorVrcCIF = value
            End Set
        End Property
        Public Property nVlrVrcCIF As Double '15
            Get
                Return _nVlrVrcCIF
            End Get
            Set(ByVal value As Double)
                _nVlrVrcCIF = value
            End Set
        End Property

        Public Property sNomCIF As String '16
            Get
                Return _sNomCIF
            End Get
            Set(ByVal value As String)
                _sNomCIF = value
            End Set
        End Property


    End Class
    Public Class ePLODP4
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sCodItm As String '4
        Private _nCanOdp As Double '5
        Private _nCanUniOdp As Double '6
        Private _nCanUniEdp As Double '7
        Private _nVrcCan As Double '8
        Private _nVlrTotReqMPD As Double
        Private _nVlrTotCnsMPD As Double '10
        Private _nVrcTotMPD As Double
        Private _nTotTieReqMOD As Double
        Private _nTotTieCnsMOD As Double
        Private _nVrcTieMOD As Double
        Private _nVlrTotReqMOD As Double '15 
        Private _nVlrTotCnsMOD As Double '16
        Private _nVrcTotMOD As Double '17
        Private _nTotTasReqCIF As Double
        Private _nTotTasCnsCIF As Double
        Private _nVrcTasCIF As Double '20
        Private _nVlrTotReqCIF As Double
        Private _nVlrTotCnsCIF As Double
        Private _nVrcTotCIF As Double
        Private _nCosTotReq As Double
        Private _nCosTotCns As Double '25
        Private _nVrcCosTot As Double
        Private _nTotUniReq As Double
        Private _nTotUniCns As Double
        Private _nVrcUni As Double
        Private _nCosUniReq As Double '30
        Private _nCosUniCns As Double
        Private _nVrcCosUni As Double
        Private _nPreVta As Double
        Private _nPorGto As Double
        Private _nPorIto As Double

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodItm As String '4
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nCanOdp As Double '5
            Get
                Return _nCanOdp
            End Get
            Set(ByVal value As Double)
                _nCanOdp = value
            End Set
        End Property
        Public Property nCanUniOdp As Double '6
            Get
                Return _nCanUniOdp
            End Get
            Set(ByVal value As Double)
                _nCanUniOdp = value
            End Set
        End Property
        Public Property nCanUniEdp As Double '7
            Get
                Return _nCanUniEdp
            End Get
            Set(ByVal value As Double)
                _nCanUniEdp = value
            End Set
        End Property
        Public Property nVrcCan As Double '8
            Get
                Return _nVrcCan
            End Get
            Set(ByVal value As Double)
                _nVrcCan = value
            End Set
        End Property
        Public Property nVlrTotReqMPD As Double '9
            Get
                Return _nVlrTotReqMPD
            End Get
            Set(ByVal value As Double)
                _nVlrTotReqMPD = value
            End Set
        End Property
        Public Property nVlrTotCnsMPD As Double '10
            Get
                Return _nVlrTotCnsMPD
            End Get
            Set(ByVal value As Double)
                _nVlrTotCnsMPD = value
            End Set
        End Property
        Public Property nVrcTotMPD As Double '11
            Get
                Return _nVrcTotMPD
            End Get
            Set(ByVal value As Double)
                _nVrcTotMPD = value
            End Set
        End Property
        Public Property nTotTieReqMOD As Double '12
            Get
                Return _nTotTieReqMOD
            End Get
            Set(ByVal value As Double)
                _nTotTieReqMOD = value
            End Set
        End Property
        Public Property nTotTieCnsMOD As Double '13
            Get
                Return _nTotTieCnsMOD
            End Get
            Set(ByVal value As Double)
                _nTotTieCnsMOD = value
            End Set
        End Property
        Public Property nVrcTieMOD As Double '14
            Get
                Return _nVrcTieMOD
            End Get
            Set(ByVal value As Double)
                _nVrcTieMOD = value
            End Set
        End Property
        Public Property nVlrTotReqMOD As Double '15
            Get
                Return _nVlrTotReqMOD
            End Get
            Set(ByVal value As Double)
                _nVlrTotReqMOD = value
            End Set
        End Property
        Public Property nVlrTotCnsMOD As Double '16
            Get
                Return _nVlrTotCnsMOD
            End Get
            Set(ByVal value As Double)
                _nVlrTotCnsMOD = value
            End Set
        End Property
        Public Property nVrcTotMOD As Double '17
            Get
                Return _nVrcTotMOD
            End Get
            Set(ByVal value As Double)
                _nVrcTotMOD = value
            End Set
        End Property
        Public Property nTotTasReqCIF As Double '18
            Get
                Return _nTotTasReqCIF
            End Get
            Set(ByVal value As Double)
                _nTotTasReqCIF = value
            End Set
        End Property
        Public Property nTotTasCnsCIF As Double
            Get
                Return _nTotTasCnsCIF
            End Get
            Set(ByVal value As Double)
                _nTotTasCnsCIF = value
            End Set
        End Property

        Public Property nVrcTasCIF As Double '20
            Get
                Return _nVrcTasCIF
            End Get
            Set(ByVal value As Double)
                _nVrcTasCIF = value
            End Set
        End Property
        Public Property nVlrTotReqCIF As Double
            Get
                Return _nVlrTotReqCIF
            End Get
            Set(ByVal value As Double)
                _nVlrTotReqCIF = value
            End Set
        End Property
        Public Property nVlrTotCnsCIF As Double
            Get
                Return _nVlrTotCnsCIF
            End Get
            Set(ByVal value As Double)
                _nVlrTotCnsCIF = value
            End Set
        End Property
        Public Property nVrcTotCIF As Double
            Get
                Return _nVrcTotCIF
            End Get
            Set(ByVal value As Double)
                _nVrcTotCIF = value
            End Set
        End Property
        Public Property nCosTotReq As Double
            Get
                Return _nCosTotReq
            End Get
            Set(ByVal value As Double)
                _nCosTotReq = value
            End Set
        End Property
        Public Property nCosTotCns As Double '25
            Get
                Return _nCosTotCns
            End Get
            Set(ByVal value As Double)
                _nCosTotCns = value
            End Set
        End Property
        Public Property nVrcCosTot As Double
            Get
                Return _nVrcCosTot
            End Get
            Set(ByVal value As Double)
                _nVrcCosTot = value
            End Set
        End Property
        Public Property nTotUniReq As Double
            Get
                Return _nTotUniReq
            End Get
            Set(ByVal value As Double)
                _nTotUniReq = value
            End Set
        End Property
        Public Property nTotUniCns As Double
            Get
                Return _nTotUniCns
            End Get
            Set(ByVal value As Double)
                _nTotUniCns = value
            End Set
        End Property
        Public Property nVrcUni As Double
            Get
                Return _nVrcUni
            End Get
            Set(ByVal value As Double)
                _nVrcUni = value
            End Set
        End Property
        Public Property nCosUniReq As Double '30
            Get
                Return _nCosUniReq
            End Get
            Set(ByVal value As Double)
                _nCosUniReq = value
            End Set
        End Property
        Public Property nCosUniCns As Double
            Get
                Return _nCosUniCns
            End Get
            Set(ByVal value As Double)
                _nCosUniCns = value
            End Set
        End Property
        Public Property nVrcCosUni As Double '32
            Get
                Return _nVrcCosUni
            End Get
            Set(ByVal value As Double)
                _nVrcCosUni = value
            End Set
        End Property
        Public Property nPreVta As Double '
            Get
                Return _nPreVta
            End Get
            Set(ByVal value As Double)
                _nPreVta = value
            End Set
        End Property
        Public Property nPorGto As Double '
            Get
                Return _nPorGto
            End Get
            Set(ByVal value As Double)
                _nPorGto = value
            End Set
        End Property
        Public Property nPorIto As Double '35
            Get
                Return _nPorIto
            End Get
            Set(ByVal value As Double)
                _nPorIto = value
            End Set
        End Property
    End Class
    Public Class ePLODP5
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sCodItm As String '4
        Private _sCodCmt As String '5
        Private _sCodAna As String '6
        Private _sNomAna As String '7
        Private _sDesAna As String '8
        Private _sCodTipAna As String '9
        Private _sNomTipAna As String '10

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sCodItm As String '4
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCmt As String '5
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property sCodAna As String '
            Get
                Return _sCodAna
            End Get
            Set(ByVal value As String)
                _sCodAna = value
            End Set
        End Property
        Public Property sNomAna As String '
            Get
                Return _sNomAna
            End Get
            Set(ByVal value As String)
                _sNomAna = value
            End Set
        End Property
        Public Property sDesAna As String '
            Get
                Return _sDesAna
            End Get
            Set(ByVal value As String)
                _sDesAna = value
            End Set
        End Property
        Public Property sCodTipAna As String '
            Get
                Return _sCodTipAna
            End Get
            Set(ByVal value As String)
                _sCodTipAna = value
            End Set
        End Property
        Public Property sNomtipAna As String '10
            Get
                Return _sNomTipAna
            End Get
            Set(ByVal value As String)
                _sNomTipAna = value
            End Set
        End Property
    End Class
    Public Class ePERCI
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sTipMov As String '4
        Private _sEstDoc As String '5
        Private _dFecCtb As Date   '6
        Private _dFecDoc As Date   '7
        Private _dFecVto As Date   '8
        Private _dFecSys As Date   '9
        Private _sCodTer As String '10
        Private _sNomTer As String '11
        Private _sDocRef As String '12
        Private _nTotHHCIF As Long
        Private _nTotMMCIF As Long
        Private _nTotTieCIF As Double '15
        Private _nTotDoc As Double
        Private _sCodCte As String
        Private _nNroCte As Long
        Private _sClsDoc As String
        Private _sCmn As String '20
        Private _sCodCteCtb As String
        Private _nNroCteCtb As Long '
        Private _nIdFECCT As Long
        Private _sNitTer As String
        Private _sTipDoc As String '25
        Private _sCodUsr As String
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipMov As String '4
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sEstDoc As String '5
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property dFecCtb As Date '6
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date '7
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date '8
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '9
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodTer As String '10
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property sDocRef As String
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotHHCIF As Long
            Get
                Return _nTotHHCIF
            End Get
            Set(ByVal value As Long)
                _nTotHHCIF = value
            End Set
        End Property
        Public Property nTotMMCIF As Long
            Get
                Return _nTotMMCIF
            End Get
            Set(ByVal value As Long)
                _nTotMMCIF = value
            End Set
        End Property
        Public Property nTotTieCIF As Double '15
            Get
                Return _nTotTieCIF
            End Get
            Set(ByVal value As Double)
                _nTotTieCIF = value
            End Set
        End Property
        Public Property nTotDoc As Double
            Get
                Return _nTotDoc
            End Get
            Set(ByVal value As Double)
                _nTotDoc = value
            End Set
        End Property
        Public Property sCodCte As String
            Get
                Return _sCodCte
            End Get
            Set(ByVal value As String)
                _sCodCte = value
            End Set
        End Property
        Public Property nNroCte As Long
            Get
                Return _nNroCte
            End Get
            Set(ByVal value As Long)
                _nNroCte = value
            End Set
        End Property
        Public Property sClsDoc As String
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCmn As String '20
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sCodCteCtb As String
            Get
                Return _sCodCteCtb
            End Get
            Set(ByVal value As String)
                _sCodCteCtb = value
            End Set
        End Property
        Public Property nNroCteCtb As Long
            Get
                Return _nNroCteCtb
            End Get
            Set(ByVal value As Long)
                _nNroCteCtb = value
            End Set
        End Property
        Public Property nIdFECCT As Long
            Get
                Return _nIdFECCT
            End Get
            Set(ByVal value As Long)
                _nIdFECCT = value
            End Set
        End Property
        Public Property sNitTer As String
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sTipDoc As String '25
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sCodUsr As String
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property

    End Class
    Public Class ePLRCI1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sTipMov As String '4
        Private _sCodDocBas As String '5
        Private _nNroDocBas As Long '6
        Private _sCodItm As String '7
        Private _nCanItm As Double '8
        Private _sCodCIF As String '9
        Private _sNomCIF As String '10
        Private _nHHCns As Long
        Private _nMMCns As Long
        Private _nTieCns As Double
        Private _nPreUni As Double
        Private _nTotLin As Double '15
        Private _sCodCco As String
        Private _nLinBas As Long
        Private _sCodPdo As String
        Private _sCodCta As String
        Private _sCtaCosVta As String '20 
        Private _bItmBlq As Boolean
        Private _sClsDoc As String
        Private _nCanOpeTer As Long
        Private _sCodCtr As String '24
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipMov As String '4
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sCodDocBas As String '5
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long '6
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCodItm As String '7
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nCanItm As Double '8
            Get
                Return _nCanItm
            End Get
            Set(ByVal value As Double)
                _nCanItm = value
            End Set
        End Property
        Public Property sCodCIF As String '9
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property sNomCIF As String '10
            Get
                Return _sNomCIF
            End Get
            Set(ByVal value As String)
                _sNomCIF = value
            End Set
        End Property
        Public Property nMMCns As Long
            Get
                Return _nMMCns
            End Get
            Set(ByVal value As Long)
                _nMMCns = value
            End Set
        End Property
        Public Property nHHCns As Long
            Get
                Return _nHHCns
            End Get
            Set(ByVal value As Long)
                _nHHCns = value
            End Set
        End Property
        Public Property nTieCns As Double
            Get
                Return _nTieCns
            End Get
            Set(ByVal value As Double)
                _nTieCns = value
            End Set
        End Property
        Public Property nPreUni As Double
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nTotLin As Double '15
            Get
                Return _nTotLin
            End Get
            Set(ByVal value As Double)
                _nTotLin = value
            End Set
        End Property
        Public Property sCodCco As String
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property nLinBas As Long
            Get
                Return _nLinBas
            End Get
            Set(ByVal value As Long)
                _nLinBas = value
            End Set
        End Property
        Public Property sCodPdo As String
            Get
                Return _sCodPdo
            End Get
            Set(ByVal value As String)
                _sCodPdo = value
            End Set
        End Property
        Public Property sCodCta As String
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property sCtaCosVta As String '20
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property bItmBlq As Boolean
            Get
                Return _bItmBlq
            End Get
            Set(ByVal value As Boolean)
                _bItmBlq = value
            End Set
        End Property
        Public Property sClsDoc As String
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property nCanOpeTer As Long
            Get
                Return _nCanOpeTer
            End Get
            Set(ByVal value As Long)
                _nCanOpeTer = value
            End Set
        End Property
        Public Property sCodCtr As String '24
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
    End Class
    Public Class ePEROP
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sTipMov As String '4
        Private _sEstDoc As String '5
        Private _dFecCtb As Date   '6
        Private _dFecDoc As Date   '7
        Private _dFecVto As Date   '8
        Private _dFecSys As Date   '9
        Private _sCodTer As String '10 
        Private _sNomTer As String '11
        Private _sDocRef As String '12
        Private _nTotHHOpe As Long '13 
        Private _nTotMMOpe As Long '14
        Private _nTotTieOpe As Double '15
        Private _nTotDoc As Double '16
        Private _sCodCte As String '17
        Private _nNroCte As Long '18
        Private _sClsDoc As String '19
        Private _sCmn As String '20
        Private _sCodCteCtb As String '21
        Private _nNroCteCtb As Long '22
        Private _nIdFECCT As Long '23
        Private _sNitTer As String '24
        Private _sTipDoc As String '25
        Private _sCodUsr As String '26
        Private _bPrp01 As Boolean '27
        Private _bPrp02 As Boolean '28
        Private _bPrp03 As Boolean '29
        Private _nTotHHCns As Long '30 
        Private _nTotMMCns As Long '31
        Private _nTotTieCns As Double '32
        Private _nTotHHAlz As Long '33
        Private _nTotMMAlz As Long '34
        Private _nTotTieAlz As Double '35
        Private _nTotHHCaf As Long '36 
        Private _nTotMMCaf As Long '37
        Private _nTotTieCaf As Double '38
       

        Private _sCodDocBas As String
        Private _nNroDocBas As Long
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipMov As String '4
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sEstDoc As String '5
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property dFecCtb As Date '6
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date '7
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date '8
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '9
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodTer As String '10
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String '11
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property sDocRef As String '12
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotHHOpe As Long '13
            Get
                Return _nTotHHOpe
            End Get
            Set(ByVal value As Long)
                _nTotHHOpe = value
            End Set
        End Property
        Public Property nTotMMOpe As Long '14
            Get
                Return _nTotMMOpe
            End Get
            Set(ByVal value As Long)
                _nTotMMOpe = value
            End Set
        End Property
        Public Property nTotTieOpe As Double '15
            Get
                Return _nTotTieOpe
            End Get
            Set(ByVal value As Double)
                _nTotTieOpe = value
            End Set
        End Property
        Public Property nTotDoc As Double '16
            Get
                Return _nTotDoc
            End Get
            Set(ByVal value As Double)
                _nTotDoc = value
            End Set
        End Property
        Public Property sCodCte As String '17
            Get
                Return _sCodCte
            End Get
            Set(ByVal value As String)
                _sCodCte = value
            End Set
        End Property
        Public Property nNroCte As Long '18
            Get
                Return _nNroCte
            End Get
            Set(ByVal value As Long)
                _nNroCte = value
            End Set
        End Property
        Public Property sClsDoc As String '19
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCmn As String '20
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sCodCteCtb As String '21
            Get
                Return _sCodCteCtb
            End Get
            Set(ByVal value As String)
                _sCodCteCtb = value
            End Set
        End Property
        Public Property nNroCteCtb As Long '22
            Get
                Return _nNroCteCtb
            End Get
            Set(ByVal value As Long)
                _nNroCteCtb = value
            End Set
        End Property
        Public Property nIdFECCT As Long '23
            Get
                Return _nIdFECCT
            End Get
            Set(ByVal value As Long)
                _nIdFECCT = value
            End Set
        End Property
        Public Property sNitTer As String '24
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sTipDoc As String '25
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sCodUsr As String '26
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property bPrp01 As Boolean '27
            Get
                Return _bPrp01
            End Get
            Set(ByVal value As Boolean)
                _bPrp01 = value
            End Set
        End Property
        Public Property bPrp02 As Boolean '28
            Get
                Return _bPrp02
            End Get
            Set(ByVal value As Boolean)
                _bPrp02 = value
            End Set
        End Property
        Public Property bPrp03 As Boolean '29
            Get
                Return _bPrp03
            End Get
            Set(ByVal value As Boolean)
                _bPrp03 = value
            End Set
        End Property
        Public Property nTotHHCns As Long '30
            Get
                Return _nTotHHCns
            End Get
            Set(ByVal value As Long)
                _nTotHHCns = value
            End Set
        End Property
        Public Property nTotMMCns As Long '31
            Get
                Return _nTotMMCns
            End Get
            Set(ByVal value As Long)
                _nTotMMCns = value
            End Set
        End Property
        Public Property nTotTieCns As Double '32
            Get
                Return _nTotTieCns
            End Get
            Set(ByVal value As Double)
                _nTotTieCns = value
            End Set
        End Property
        Public Property nTotHHAlz As Long '33
            Get
                Return _nTotHHAlz
            End Get
            Set(ByVal value As Long)
                _nTotHHAlz = value
            End Set
        End Property
        Public Property nTotMMAlz As Long '34
            Get
                Return _nTotMMAlz
            End Get
            Set(ByVal value As Long)
                _nTotMMAlz = value
            End Set
        End Property
        Public Property nTotTieAlz As Double '35
            Get
                Return _nTotTieAlz
            End Get
            Set(ByVal value As Double)
                _nTotTieAlz = value
            End Set
        End Property
        Public Property nTotHHCaf As Long '36
            Get
                Return _nTotHHCaf
            End Get
            Set(ByVal value As Long)
                _nTotHHCaf = value
            End Set
        End Property
        Public Property nTotMMCaf As Long '37
            Get
                Return _nTotMMCaf
            End Get
            Set(ByVal value As Long)
                _nTotMMCaf = value
            End Set
        End Property
        Public Property nTotTieCaf As Double '38
            Get
                Return _nTotTieCaf
            End Get
            Set(ByVal value As Double)
                _nTotTieCaf = value
            End Set
        End Property

        Public Property sCodDocBas As String
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property

        Public Property nNroDocBas As Long
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
    End Class
    Public Class ePLROP1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sTipMov As String '4
        Private _sCodDocBas As String '5
        Private _sCodSerBas As String
        Private _nNroDocBas As Long
        Private _sCodItm As String
        Private _nCanItm As Double
        Private _sCodOpe As String '10
        Private _sNomOpe As String
        Private _nHHIniOpe As Long
        Private _nMMIniOpe As Long
        Private _nHHFinOpe As Long
        Private _nMMFinOpe As Long '15 
        Private _nHHCnsOpe As Long
        Private _nMMCnsOpe As Long
        Private _nTieCnsOpe As Long
        Private _nHHCns As Long
        Private _nMMCns As Long '20
        Private _nTieCns As Long
        Private _nTieReq As Double
        Private _nPreUni As Double '
        Private _nTotLin As Double
        Private _sCodCco As String '25
        Private _nLinBas As Long
        Private _sCodPdo As String
        Private _sCodCta As String
        Private _sCtaCosVta As String
        Private _bItmBlq As Boolean '30
        Private _sClsDoc As String
        Private _nCanOpeTer As Long
        Private _sCodCtr As String '33
        Private _nHHIniAlz As Long
        Private _nMMIniAlz As Long '35
        Private _nHHFinAlz As Long
        Private _nMMFinAlz As Long
        Private _nHHCnsAlz As Long
        Private _nMMCnsAlz As Long
        Private _nTieCnsAlz As Long '40
        Private _nHHIniCaf As Long
        Private _nMMIniCaf As Long
        Private _nHHFinCaf As Long
        Private _nMMFinCaf As Long
        Private _nHHCnsCaf As Long '45
        Private _nMMCnsCaf As Long
        Private _nTieCnsCaf As Long '47
        Private _nIdPEROP As Long '0
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property nIdPEROP As Long '0
            Get
                Return _nIdPEROP
            End Get
            Set(ByVal value As Long)
                _nIdPEROP = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipMov As String '4
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sCodDocBas As String '5
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property sCodSerBas As String '6
            Get
                Return _sCodSerBas
            End Get
            Set(ByVal value As String)
                _sCodSerBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long '7
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property sCodItm As String '8
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nCanItm As Double '9
            Get
                Return _nCanItm
            End Get
            Set(ByVal value As Double)
                _nCanItm = value
            End Set
        End Property
        Public Property sCodOpe As String '10
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property sNomOpe As String '11
            Get
                Return _sNomOpe
            End Get
            Set(ByVal value As String)
                _sNomOpe = value
            End Set
        End Property
        Public Property nHHIniOpe As Long '12
            Get
                Return _nHHIniOpe
            End Get
            Set(ByVal value As Long)
                _nHHIniOpe = value
            End Set
        End Property
        Public Property nMMIniOpe As Long
            Get
                Return _nMMIniOpe
            End Get
            Set(ByVal value As Long)
                _nMMIniOpe = value
            End Set
        End Property
        Public Property nHHFinOpe As Long
            Get
                Return _nHHFinOpe
            End Get
            Set(ByVal value As Long)
                _nHHFinOpe = value
            End Set
        End Property
        Public Property nMMFinOpe As Long '15
            Get
                Return _nMMFinOpe
            End Get
            Set(ByVal value As Long)
                _nMMFinOpe = value
            End Set
        End Property
        Public Property nHHCnsOpe As Long '
            Get
                Return _nHHCnsOpe
            End Get
            Set(ByVal value As Long)
                _nHHCnsOpe = value
            End Set
        End Property
        Public Property nMMCnsOpe As Long '
            Get
                Return _nMMCnsOpe
            End Get
            Set(ByVal value As Long)
                _nMMCnsOpe = value
            End Set
        End Property
        Public Property nTieCnsOpe As Long '
            Get
                Return _nTieCnsOpe
            End Get
            Set(ByVal value As Long)
                _nTieCnsOpe = value
            End Set
        End Property
        Public Property nHHCns As Long '
            Get
                Return _nHHCns
            End Get
            Set(ByVal value As Long)
                _nHHCns = value
            End Set
        End Property
        Public Property nMMCns As Long '20
            Get
                Return _nMMCns
            End Get
            Set(ByVal value As Long)
                _nMMCns = value
            End Set
        End Property
        Public Property nTieCns As Double '
            Get
                Return _nTieCns
            End Get
            Set(ByVal value As Double)
                _nTieCns = value
            End Set
        End Property
        Public Property nTieReq As Double '
            Get
                Return _nTieReq
            End Get
            Set(ByVal value As Double)
                _nTieReq = value
            End Set
        End Property
        Public Property nPreUni As Double '
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nTotLin As Double '
            Get
                Return _nTotLin
            End Get
            Set(ByVal value As Double)
                _nTotLin = value
            End Set
        End Property
        Public Property sCodCco As String '25
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property nLinBas As Long '
            Get
                Return _nLinBas
            End Get
            Set(ByVal value As Long)
                _nLinBas = value
            End Set
        End Property
        Public Property sCodPdo As String '
            Get
                Return _sCodPdo
            End Get
            Set(ByVal value As String)
                _sCodPdo = value
            End Set
        End Property
        Public Property sCodCta As String '
            Get
                Return _sCodCta
            End Get
            Set(ByVal value As String)
                _sCodCta = value
            End Set
        End Property
        Public Property sCtaCosVta As String '
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property bItmBlq As Boolean '30
            Get
                Return _bItmBlq
            End Get
            Set(ByVal value As Boolean)
                _bItmBlq = value
            End Set
        End Property
        Public Property sClsDoc As String '
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property nCanOpeTer As Long '
            Get
                Return _nCanOpeTer
            End Get
            Set(ByVal value As Long)
                _nCanOpeTer = value
            End Set
        End Property
        Public Property sCodCtr As String '33
            Get
                Return _sCodCtr
            End Get
            Set(ByVal value As String)
                _sCodCtr = value
            End Set
        End Property
        Public Property nHHIniAlz As Long '34
            Get
                Return _nHHIniAlz
            End Get
            Set(ByVal value As Long)
                _nHHIniAlz = value
            End Set
        End Property
        Public Property nMMIniAlz As Long
            Get
                Return _nMMIniAlz
            End Get
            Set(ByVal value As Long)
                _nMMIniAlz = value
            End Set
        End Property
        Public Property nHHFinAlz As Long
            Get
                Return _nHHFinAlz
            End Get
            Set(ByVal value As Long)
                _nHHFinAlz = value
            End Set
        End Property
        Public Property nMMFinAlz As Long '37
            Get
                Return _nMMFinAlz
            End Get
            Set(ByVal value As Long)
                _nMMFinAlz = value
            End Set
        End Property
        Public Property nHHCnsAlz As Long '38
            Get
                Return _nHHCnsAlz
            End Get
            Set(ByVal value As Long)
                _nHHCnsAlz = value
            End Set
        End Property
        Public Property nMMCnsAlz As Long '
            Get
                Return _nMMCnsAlz
            End Get
            Set(ByVal value As Long)
                _nMMCnsAlz = value
            End Set
        End Property
        Public Property nTieCnsAlz As Long '40
            Get
                Return _nTieCnsAlz
            End Get
            Set(ByVal value As Long)
                _nTieCnsAlz = value
            End Set
        End Property
        Public Property nHHIniCaf As Long '
            Get
                Return _nHHIniCaf
            End Get
            Set(ByVal value As Long)
                _nHHIniCaf = value
            End Set
        End Property
        Public Property nMMIniCaf As Long
            Get
                Return _nMMIniCaf
            End Get
            Set(ByVal value As Long)
                _nMMIniCaf = value
            End Set
        End Property
        Public Property nHHFinCaf As Long
            Get
                Return _nHHFinCaf
            End Get
            Set(ByVal value As Long)
                _nHHFinCaf = value
            End Set
        End Property
        Public Property nMMFinCaf As Long '
            Get
                Return _nMMFinCaf
            End Get
            Set(ByVal value As Long)
                _nMMFinCaf = value
            End Set
        End Property
        Public Property nHHCnsCaf As Long '45
            Get
                Return _nHHCnsCaf
            End Get
            Set(ByVal value As Long)
                _nHHCnsCaf = value
            End Set
        End Property
        Public Property nMMCnsCaf As Long '
            Get
                Return _nMMCnsCaf
            End Get
            Set(ByVal value As Long)
                _nMMCnsCaf = value
            End Set
        End Property
        Public Property nTieCnsCaf As Long '47
            Get
                Return _nTieCnsCaf
            End Get
            Set(ByVal value As Long)
                _nTieCnsCaf = value
            End Set
        End Property
    End Class
    Public Class ePELROP1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sTipMov As String '4
        Private _sEstDoc As String '5
        Private _dFecCtb As Date   '6
        Private _dFecDoc As Date   '7
        Private _dFecVto As Date   '8
        Private _dFecSys As Date   '9
        Private _sCodTer As String '10 
        Private _sNomTer As String '11
        Private _sDocRef As String '12
        Private _nTotHHOpe As Long '13 
        Private _nTotMMOpe As Long '14
        Private _nTotTieOpe As Double '15
        Private _nTotDoc As Double '16
        Private _sCodCte As String '17
        Private _nNroCte As Long '18
        Private _sClsDoc As String '19
        Private _sCmn As String '20
        Private _sCodCteCtb As String '21
        Private _nNroCteCtb As Long '22
        Private _nIdFECCT As Long '23
        Private _sNitTer As String '24
        Private _sTipDoc As String '25
        Private _sCodUsr As String '26
        Private _bPrp01 As Boolean '27
        Private _bPrp02 As Boolean '28
        Private _bPrp03 As Boolean '29
        Private _nTotHHCns As Long '30 
        Private _nTotMMCns As Long '31
        Private _nTotTieCns As Double '32
        Private _nTotHHAlz As Long '33
        Private _nTotMMAlz As Long '34
        Private _nTotTieAlz As Double '35
        Private _nTotHHCaf As Long '36 
        Private _nTotMMCaf As Long '37
        Private _nTotTieCaf As Double '38

        Private _xnId As Long '0
        Private _xsCodDoc As String '1
        Private _xnNroDoc As Long '2
        Private _xsCodSer As String '3
        Private _xsTipMov As String '4
        Private _xsCodDocBas As String '5
        Private _xsCodSerBas As String
        Private _xnNroDocBas As Long
        Private _xsCodItm As String
        Private _xnCanItm As Double
        Private _xsCodOpe As String '10
        Private _xsNomOpe As String
        Private _xnHHIniOpe As Long
        Private _xnMMIniOpe As Long
        Private _xnHHFinOpe As Long
        Private _xnMMFinOpe As Long '15 
        Private _xnHHCnsOpe As Long
        Private _xnMMCnsOpe As Long
        Private _xnTieCnsOpe As Long
        Private _xnHHCns As Long
        Private _xnMMCns As Long '20
        Private _xnTieCns As Long
        Private _xnTieReq As Double
        Private _xnPreUni As Double '
        Private _xnTotLin As Double
        Private _xsCodCco As String '25
        Private _xnLinBas As Long
        Private _xsCodPdo As String
        Private _xsCodCta As String
        Private _xsCtaCosVta As String
        Private _xbItmBlq As Boolean '30
        Private _xsClsDoc As String
        Private _xnCanOpeTer As Long
        Private _xsCodCtr As String '33
        Private _xnHHIniAlz As Long
        Private _xnMMIniAlz As Long '35
        Private _xnHHFinAlz As Long
        Private _xnMMFinAlz As Long
        Private _xnHHCnsAlz As Long
        Private _xnMMCnsAlz As Long
        Private _xnTieCnsAlz As Long '40
        Private _xnHHIniCaf As Long
        Private _xnMMIniCaf As Long
        Private _xnHHFinCaf As Long
        Private _xnMMFinCaf As Long
        Private _xnHHCnsCaf As Long '45
        Private _xnMMCnsCaf As Long
        Private _xnTieCnsCaf As Long '47
        Private _xnIdPEROP As Long '0

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property

        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sTipMov As String '4
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property sEstDoc As String '5
            Get
                Return _sEstDoc
            End Get
            Set(ByVal value As String)
                _sEstDoc = value
            End Set
        End Property
        Public Property dFecCtb As Date '6
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date '7
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date '8
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '9
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodTer As String '10
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String '11
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property sDocRef As String '12
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotHHOpe As Long '13
            Get
                Return _nTotHHOpe
            End Get
            Set(ByVal value As Long)
                _nTotHHOpe = value
            End Set
        End Property
        Public Property nTotMMOpe As Long '14
            Get
                Return _nTotMMOpe
            End Get
            Set(ByVal value As Long)
                _nTotMMOpe = value
            End Set
        End Property
        Public Property nTotTieOpe As Double '15
            Get
                Return _nTotTieOpe
            End Get
            Set(ByVal value As Double)
                _nTotTieOpe = value
            End Set
        End Property
        Public Property nTotDoc As Double '16
            Get
                Return _nTotDoc
            End Get
            Set(ByVal value As Double)
                _nTotDoc = value
            End Set
        End Property
        Public Property sCodCte As String '17
            Get
                Return _sCodCte
            End Get
            Set(ByVal value As String)
                _sCodCte = value
            End Set
        End Property
        Public Property nNroCte As Long '18
            Get
                Return _nNroCte
            End Get
            Set(ByVal value As Long)
                _nNroCte = value
            End Set
        End Property
        Public Property sClsDoc As String '19
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCmn As String '20
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
        Public Property sCodCteCtb As String '21
            Get
                Return _sCodCteCtb
            End Get
            Set(ByVal value As String)
                _sCodCteCtb = value
            End Set
        End Property
        Public Property nNroCteCtb As Long '22
            Get
                Return _nNroCteCtb
            End Get
            Set(ByVal value As Long)
                _nNroCteCtb = value
            End Set
        End Property
        Public Property nIdFECCT As Long '23
            Get
                Return _nIdFECCT
            End Get
            Set(ByVal value As Long)
                _nIdFECCT = value
            End Set
        End Property
        Public Property sNitTer As String '24
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sTipDoc As String '25
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sCodUsr As String '26
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property bPrp01 As Boolean '27
            Get
                Return _bPrp01
            End Get
            Set(ByVal value As Boolean)
                _bPrp01 = value
            End Set
        End Property
        Public Property bPrp02 As Boolean '28
            Get
                Return _bPrp02
            End Get
            Set(ByVal value As Boolean)
                _bPrp02 = value
            End Set
        End Property
        Public Property bPrp03 As Boolean '29
            Get
                Return _bPrp03
            End Get
            Set(ByVal value As Boolean)
                _bPrp03 = value
            End Set
        End Property
        Public Property nTotHHCns As Long '30
            Get
                Return _nTotHHCns
            End Get
            Set(ByVal value As Long)
                _nTotHHCns = value
            End Set
        End Property
        Public Property nTotMMCns As Long '31
            Get
                Return _nTotMMCns
            End Get
            Set(ByVal value As Long)
                _nTotMMCns = value
            End Set
        End Property
        Public Property nTotTieCns As Double '32
            Get
                Return _nTotTieCns
            End Get
            Set(ByVal value As Double)
                _nTotTieCns = value
            End Set
        End Property
        Public Property nTotHHAlz As Long '33
            Get
                Return _nTotHHAlz
            End Get
            Set(ByVal value As Long)
                _nTotHHAlz = value
            End Set
        End Property
        Public Property nTotMMAlz As Long '34
            Get
                Return _nTotMMAlz
            End Get
            Set(ByVal value As Long)
                _nTotMMAlz = value
            End Set
        End Property
        Public Property nTotTieAlz As Double '35
            Get
                Return _nTotTieAlz
            End Get
            Set(ByVal value As Double)
                _nTotTieAlz = value
            End Set
        End Property
        Public Property nTotHHCaf As Long '36
            Get
                Return _nTotHHCaf
            End Get
            Set(ByVal value As Long)
                _nTotHHCaf = value
            End Set
        End Property
        Public Property nTotMMCaf As Long '37
            Get
                Return _nTotMMCaf
            End Get
            Set(ByVal value As Long)
                _nTotMMCaf = value
            End Set
        End Property
        Public Property nTotTieCaf As Double '38
            Get
                Return _nTotTieCaf
            End Get
            Set(ByVal value As Double)
                _nTotTieCaf = value
            End Set
        End Property

        Public Property xnId As Long '0
            Get
                Return _xnId
            End Get
            Set(ByVal value As Long)
                _xnId = value
            End Set
        End Property
        Public Property xsCodDoc As String '1
            Get
                Return _xsCodDoc
            End Get
            Set(ByVal value As String)
                _xsCodDoc = value
            End Set
        End Property
        Public Property xnNroDoc As Long '2
            Get
                Return _xnNroDoc
            End Get
            Set(ByVal value As Long)
                _xnNroDoc = value
            End Set
        End Property
        Public Property xsCodSer As String '3
            Get
                Return _xsCodSer
            End Get
            Set(ByVal value As String)
                _xsCodSer = value
            End Set
        End Property
        Public Property xsTipMov As String '4
            Get
                Return _xsTipMov
            End Get
            Set(ByVal value As String)
                _xsTipMov = value
            End Set
        End Property
        Public Property xsCodDocBas As String '5
            Get
                Return _xsCodDocBas
            End Get
            Set(ByVal value As String)
                _xsCodDocBas = value
            End Set
        End Property
        Public Property xsCodSerBas As String '6
            Get
                Return _xsCodSerBas
            End Get
            Set(ByVal value As String)
                _xsCodSerBas = value
            End Set
        End Property
        Public Property xnNroDocBas As Long '7
            Get
                Return _xnNroDocBas
            End Get
            Set(ByVal value As Long)
                _xnNroDocBas = value
            End Set
        End Property
        Public Property xsCodItm As String '8
            Get
                Return _xsCodItm
            End Get
            Set(ByVal value As String)
                _xsCodItm = value
            End Set
        End Property
        Public Property xnCanItm As Double '9
            Get
                Return _xnCanItm
            End Get
            Set(ByVal value As Double)
                _xnCanItm = value
            End Set
        End Property
        Public Property xsCodOpe As String '10
            Get
                Return _xsCodOpe
            End Get
            Set(ByVal value As String)
                _xsCodOpe = value
            End Set
        End Property
        Public Property xsNomOpe As String '11
            Get
                Return _xsNomOpe
            End Get
            Set(ByVal value As String)
                _xsNomOpe = value
            End Set
        End Property
        Public Property xnHHIniOpe As Long '12
            Get
                Return _xnHHIniOpe
            End Get
            Set(ByVal value As Long)
                _xnHHIniOpe = value
            End Set
        End Property
        Public Property xnMMIniOpe As Long
            Get
                Return _xnMMIniOpe
            End Get
            Set(ByVal value As Long)
                _xnMMIniOpe = value
            End Set
        End Property
        Public Property xnHHFinOpe As Long
            Get
                Return _xnHHFinOpe
            End Get
            Set(ByVal value As Long)
                _xnHHFinOpe = value
            End Set
        End Property
        Public Property xnMMFinOpe As Long '15
            Get
                Return _xnMMFinOpe
            End Get
            Set(ByVal value As Long)
                _xnMMFinOpe = value
            End Set
        End Property
        Public Property xnHHCnsOpe As Long '
            Get
                Return _xnHHCnsOpe
            End Get
            Set(ByVal value As Long)
                _xnHHCnsOpe = value
            End Set
        End Property
        Public Property xnMMCnsOpe As Long '
            Get
                Return _xnMMCnsOpe
            End Get
            Set(ByVal value As Long)
                _xnMMCnsOpe = value
            End Set
        End Property
        Public Property xnTieCnsOpe As Long '
            Get
                Return _xnTieCnsOpe
            End Get
            Set(ByVal value As Long)
                _xnTieCnsOpe = value
            End Set
        End Property
        Public Property xnHHCns As Long '
            Get
                Return _xnHHCns
            End Get
            Set(ByVal value As Long)
                _xnHHCns = value
            End Set
        End Property
        Public Property xnMMCns As Long '20
            Get
                Return _xnMMCns
            End Get
            Set(ByVal value As Long)
                _xnMMCns = value
            End Set
        End Property
        Public Property xnTieCns As Double '
            Get
                Return _xnTieCns
            End Get
            Set(ByVal value As Double)
                _xnTieCns = value
            End Set
        End Property
        Public Property xnTieReq As Double '
            Get
                Return _xnTieReq
            End Get
            Set(ByVal value As Double)
                _xnTieReq = value
            End Set
        End Property
        Public Property xnPreUni As Double '
            Get
                Return _xnPreUni
            End Get
            Set(ByVal value As Double)
                _xnPreUni = value
            End Set
        End Property
        Public Property xnTotLin As Double '
            Get
                Return _xnTotLin
            End Get
            Set(ByVal value As Double)
                _xnTotLin = value
            End Set
        End Property
        Public Property xsCodCco As String '25
            Get
                Return _xsCodCco
            End Get
            Set(ByVal value As String)
                _xsCodCco = value
            End Set
        End Property
        Public Property xnLinBas As Long '
            Get
                Return _xnLinBas
            End Get
            Set(ByVal value As Long)
                _xnLinBas = value
            End Set
        End Property
        Public Property xsCodPdo As String '
            Get
                Return _xsCodPdo
            End Get
            Set(ByVal value As String)
                _xsCodPdo = value
            End Set
        End Property
        Public Property xsCodCta As String '
            Get
                Return _xsCodCta
            End Get
            Set(ByVal value As String)
                _xsCodCta = value
            End Set
        End Property
        Public Property xsCtaCosVta As String '
            Get
                Return _xsCtaCosVta
            End Get
            Set(ByVal value As String)
                _xsCtaCosVta = value
            End Set
        End Property
        Public Property xbItmBlq As Boolean '30
            Get
                Return _xbItmBlq
            End Get
            Set(ByVal value As Boolean)
                _xbItmBlq = value
            End Set
        End Property
        Public Property xsClsDoc As String '
            Get
                Return _xsClsDoc
            End Get
            Set(ByVal value As String)
                _xsClsDoc = value
            End Set
        End Property
        Public Property xnCanOpeTer As Long '
            Get
                Return _xnCanOpeTer
            End Get
            Set(ByVal value As Long)
                _xnCanOpeTer = value
            End Set
        End Property
        Public Property xsCodCtr As String '33
            Get
                Return _xsCodCtr
            End Get
            Set(ByVal value As String)
                _xsCodCtr = value
            End Set
        End Property
        Public Property xnHHIniAlz As Long '34
            Get
                Return _xnHHIniAlz
            End Get
            Set(ByVal value As Long)
                _xnHHIniAlz = value
            End Set
        End Property
        Public Property xnMMIniAlz As Long
            Get
                Return _xnMMIniAlz
            End Get
            Set(ByVal value As Long)
                _xnMMIniAlz = value
            End Set
        End Property
        Public Property xnHHFinAlz As Long
            Get
                Return _xnHHFinAlz
            End Get
            Set(ByVal value As Long)
                _xnHHFinAlz = value
            End Set
        End Property
        Public Property xnMMFinAlz As Long '37
            Get
                Return _xnMMFinAlz
            End Get
            Set(ByVal value As Long)
                _xnMMFinAlz = value
            End Set
        End Property
        Public Property xnHHCnsAlz As Long '38
            Get
                Return _xnHHCnsAlz
            End Get
            Set(ByVal value As Long)
                _xnHHCnsAlz = value
            End Set
        End Property
        Public Property xnMMCnsAlz As Long '
            Get
                Return _xnMMCnsAlz
            End Get
            Set(ByVal value As Long)
                _xnMMCnsAlz = value
            End Set
        End Property
        Public Property xnTieCnsAlz As Long '40
            Get
                Return _xnTieCnsAlz
            End Get
            Set(ByVal value As Long)
                _xnTieCnsAlz = value
            End Set
        End Property
        Public Property xnHHIniCaf As Long '
            Get
                Return _xnHHIniCaf
            End Get
            Set(ByVal value As Long)
                _xnHHIniCaf = value
            End Set
        End Property
        Public Property xnMMIniCaf As Long
            Get
                Return _xnMMIniCaf
            End Get
            Set(ByVal value As Long)
                _xnMMIniCaf = value
            End Set
        End Property
        Public Property xnHHFinCaf As Long
            Get
                Return _xnHHFinCaf
            End Get
            Set(ByVal value As Long)
                _xnHHFinCaf = value
            End Set
        End Property
        Public Property xnMMFinCaf As Long '
            Get
                Return _xnMMFinCaf
            End Get
            Set(ByVal value As Long)
                _xnMMFinCaf = value
            End Set
        End Property
        Public Property xnHHCnsCaf As Long '45
            Get
                Return _xnHHCnsCaf
            End Get
            Set(ByVal value As Long)
                _xnHHCnsCaf = value
            End Set
        End Property
        Public Property xnMMCnsCaf As Long '
            Get
                Return _xnMMCnsCaf
            End Get
            Set(ByVal value As Long)
                _xnMMCnsCaf = value
            End Set
        End Property
        Public Property xnTieCnsCaf As Long '47
            Get
                Return _xnTieCnsCaf
            End Get
            Set(ByVal value As Long)
                _xnTieCnsCaf = value
            End Set
        End Property
        Public Property xnIdPEROP As Long '0
            Get
                Return _xnIdPEROP
            End Get
            Set(ByVal value As Long)
                _xnIdPEROP = value
            End Set
        End Property

    End Class
    Public Class ePEODP_PLODP4
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodSer As String '3
        Private _sNroLot As String '4
        Private _sEstOdp As String '5
        Private _sCodItm As String '6
        Private _sNomItm As String '7
        Private _nCanLotStn As Double
        Private _sUniMedStn As String '
        Private _nCanUniStn As Double '10
        Private _nCanOdp As Double '11
        Private _sUniMedOdp As String '
        Private _nCanUniOdp As Double '
        Private _sUniMedInv As String '
        Private _nCanUniEdp As Double '15
        Private _nTieItm As Double '
        Private _nTotTieOdp As Double '
        Private _nTotTieEdp As Double '
        Private _sCodAlm As String '
        Private _dFecEmi As Date '20
        Private _dFecIni As Date '
        Private _dFecFin As Date '
        Private _dFecSys As Date ' 
        Private _sClsDoc As String '
        Private _sCodUsr As String '25
        Private _sRegSan As String '26
        Private _sCmn As String

        
        Private _T1nId As Long '0
        Private _T1sCodDoc As String '1
        Private _T1nNroDoc As Long '2
        Private _T1sCodSer As String '3
        Private _T1sCodItm As String '4
        Private _T1nCanOdp As Double '5
        Private _T1nCanUniOdp As Double '6
        Private _T1nCanUniEdp As Double '7
        Private _nVrcCan As Double '8
        Private _nVlrTotReqMPD As Double
        Private _nVlrTotCnsMPD As Double '10
        Private _nVrcTotMPD As Double
        Private _nTotTieReqMOD As Double
        Private _nTotTieCnsMOD As Double
        Private _nVrcTieMOD As Double
        Private _nVlrTotReqMOD As Double '15 
        Private _nVlrTotCnsMOD As Double '16
        Private _nVrcTotMOD As Double '17
        Private _nTotTasReqCIF As Double
        Private _nTotTasCnsCIF As Double
        Private _nVrcTasCIF As Double '20
        Private _nVlrTotReqCIF As Double
        Private _nVlrTotCnsCIF As Double
        Private _nVrcTotCIF As Double
        Private _nCosTotReq As Double
        Private _nCosTotCns As Double '25
        Private _nVrcCosTot As Double
        Private _nTotUniReq As Double
        Private _nTotUniCns As Double
        Private _nVrcUni As Double
        Private _nCosUniReq As Double '30
        Private _nCosUniCns As Double
        Private _nVrcCosUni As Double
        Private _nPreVta As Double
        Private _nPorGto As Double
        Private _nPorIto As Double


        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property nNroDoc As Long '2
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
            End Set
        End Property
        Public Property sCodSer As String '3
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sNroLot As String '4
            Get
                Return _sNroLot
            End Get
            Set(ByVal value As String)
                _sNroLot = value
            End Set
        End Property
        Public Property sEstOdp As String '5
            Get
                Return _sEstOdp
            End Get
            Set(ByVal value As String)
                _sEstOdp = value
            End Set
        End Property
        Public Property sCodItm As String '7
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property nCanLotStn As Double '7
            Get
                Return _nCanLotStn
            End Get
            Set(ByVal value As Double)
                _nCanLotStn = value
            End Set
        End Property
        Public Property sUniMedStn As String '8
            Get
                Return _sUniMedStn
            End Get
            Set(ByVal value As String)
                _sUniMedStn = value
            End Set
        End Property
        Public Property nCanUniStn As Double '9
            Get
                Return _nCanUniStn
            End Get
            Set(ByVal value As Double)
                _nCanUniStn = value
            End Set
        End Property
        Public Property nCanOdp As Double '10
            Get
                Return _nCanOdp
            End Get
            Set(ByVal value As Double)
                _nCanOdp = value
            End Set
        End Property
        Public Property sUniMedOdp As String '11
            Get
                Return _sUniMedOdp
            End Get
            Set(ByVal value As String)
                _sUniMedOdp = value
            End Set
        End Property
        Public Property nCanUniOdp As Double '12
            Get
                Return _nCanUniOdp
            End Get
            Set(ByVal value As Double)
                _nCanUniOdp = value
            End Set
        End Property
        Public Property sUniMedInv As String '13
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nCanUniEdp As Double '14
            Get
                Return _nCanUniEdp
            End Get
            Set(ByVal value As Double)
                _nCanUniEdp = value
            End Set
        End Property
        Public Property nTieItm As Double '15
            Get
                Return _nTieItm
            End Get
            Set(ByVal value As Double)
                _nTieItm = value
            End Set
        End Property
        Public Property nTotTieOdp As Double '16
            Get
                Return _nTotTieOdp
            End Get
            Set(ByVal value As Double)
                _nTotTieOdp = value
            End Set
        End Property
        Public Property nTotTieEdp As Double '17
            Get
                Return _nTotTieEdp
            End Get
            Set(ByVal value As Double)
                _nTotTieEdp = value
            End Set
        End Property
        Public Property sCodAlm As String '18
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property dFecEmi As Date '19
            Get
                Return _dFecEmi
            End Get
            Set(ByVal value As Date)
                _dFecEmi = value
            End Set
        End Property
        Public Property dFecIni As Date '20
            Get
                Return _dFecIni
            End Get
            Set(ByVal value As Date)
                _dFecIni = value
            End Set
        End Property
        Public Property dFecFin As Date '21
            Get
                Return _dFecFin
            End Get
            Set(ByVal value As Date)
                _dFecFin = value
            End Set
        End Property
        Public Property dFecSys As Date '22
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sClsDoc As String '23
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sCodUsr As String '24
            Get
                Return _sCodUsr
            End Get
            Set(ByVal value As String)
                _sCodUsr = value
            End Set
        End Property
        Public Property sRegSan As String '15
            Get
                Return _sRegSan
            End Get
            Set(ByVal value As String)
                _sRegSan = value
            End Set
        End Property
        Public Property sCmn As String '
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property


        Public Property sNomItm As String '25
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property

        'PLODP4 - T1
        Public Property T1nId As Long '0
            Get
                Return _T1nId
            End Get
            Set(ByVal value As Long)
                _T1nId = value
            End Set
        End Property
        Public Property T1sCodDoc As String '1
            Get
                Return _T1sCodDoc
            End Get
            Set(ByVal value As String)
                _T1sCodDoc = value
            End Set
        End Property
        Public Property T1nNroDoc As Long '2
            Get
                Return _T1nNroDoc
            End Get
            Set(ByVal value As Long)
                _T1nNroDoc = value
            End Set
        End Property
        Public Property T1sCodSer As String '3
            Get
                Return _T1sCodSer
            End Get
            Set(ByVal value As String)
                _T1sCodSer = value
            End Set
        End Property
        Public Property T1sCodItm As String '4
            Get
                Return _T1sCodItm
            End Get
            Set(ByVal value As String)
                _T1sCodItm = value
            End Set
        End Property
        Public Property T1nCanOdp As Double '5
            Get
                Return _T1nCanOdp
            End Get
            Set(ByVal value As Double)
                _T1nCanOdp = value
            End Set
        End Property
        Public Property T1nCanUniOdp As Double '6
            Get
                Return _T1nCanUniOdp
            End Get
            Set(ByVal value As Double)
                _T1nCanUniOdp = value
            End Set
        End Property
        Public Property T1nCanUniEdp As Double '7
            Get
                Return _T1nCanUniEdp
            End Get
            Set(ByVal value As Double)
                _T1nCanUniEdp = value
            End Set
        End Property
        Public Property nVrcCan As Double '8
            Get
                Return _nVrcCan
            End Get
            Set(ByVal value As Double)
                _nVrcCan = value
            End Set
        End Property
        Public Property nVlrTotReqMPD As Double '9
            Get
                Return _nVlrTotReqMPD
            End Get
            Set(ByVal value As Double)
                _nVlrTotReqMPD = value
            End Set
        End Property
        Public Property nVlrTotCnsMPD As Double '10
            Get
                Return _nVlrTotCnsMPD
            End Get
            Set(ByVal value As Double)
                _nVlrTotCnsMPD = value
            End Set
        End Property
        Public Property nVrcTotMPD As Double '11
            Get
                Return _nVrcTotMPD
            End Get
            Set(ByVal value As Double)
                _nVrcTotMPD = value
            End Set
        End Property
        Public Property nTotTieReqMOD As Double '12
            Get
                Return _nTotTieReqMOD
            End Get
            Set(ByVal value As Double)
                _nTotTieReqMOD = value
            End Set
        End Property
        Public Property nTotTieCnsMOD As Double '13
            Get
                Return _nTotTieCnsMOD
            End Get
            Set(ByVal value As Double)
                _nTotTieCnsMOD = value
            End Set
        End Property
        Public Property nVrcTieMOD As Double '14
            Get
                Return _nVrcTieMOD
            End Get
            Set(ByVal value As Double)
                _nVrcTieMOD = value
            End Set
        End Property
        Public Property nVlrTotReqMOD As Double '15
            Get
                Return _nVlrTotReqMOD
            End Get
            Set(ByVal value As Double)
                _nVlrTotReqMOD = value
            End Set
        End Property
        Public Property nVlrTotCnsMOD As Double '16
            Get
                Return _nVlrTotCnsMOD
            End Get
            Set(ByVal value As Double)
                _nVlrTotCnsMOD = value
            End Set
        End Property
        Public Property nVrcTotMOD As Double '17
            Get
                Return _nVrcTotMOD
            End Get
            Set(ByVal value As Double)
                _nVrcTotMOD = value
            End Set
        End Property
        Public Property nTotTasReqCIF As Double '18
            Get
                Return _nTotTasReqCIF
            End Get
            Set(ByVal value As Double)
                _nTotTasReqCIF = value
            End Set
        End Property
        Public Property nTotTasCnsCIF As Double
            Get
                Return _nTotTasCnsCIF
            End Get
            Set(ByVal value As Double)
                _nTotTasCnsCIF = value
            End Set
        End Property

        Public Property nVrcTasCIF As Double '20
            Get
                Return _nVrcTasCIF
            End Get
            Set(ByVal value As Double)
                _nVrcTasCIF = value
            End Set
        End Property
        Public Property nVlrTotReqCIF As Double
            Get
                Return _nVlrTotReqCIF
            End Get
            Set(ByVal value As Double)
                _nVlrTotReqCIF = value
            End Set
        End Property
        Public Property nVlrTotCnsCIF As Double
            Get
                Return _nVlrTotCnsCIF
            End Get
            Set(ByVal value As Double)
                _nVlrTotCnsCIF = value
            End Set
        End Property
        Public Property nVrcTotCIF As Double
            Get
                Return _nVrcTotCIF
            End Get
            Set(ByVal value As Double)
                _nVrcTotCIF = value
            End Set
        End Property
        Public Property nCosTotReq As Double
            Get
                Return _nCosTotReq
            End Get
            Set(ByVal value As Double)
                _nCosTotReq = value
            End Set
        End Property
        Public Property nCosTotCns As Double '25
            Get
                Return _nCosTotCns
            End Get
            Set(ByVal value As Double)
                _nCosTotCns = value
            End Set
        End Property
        Public Property nVrcCosTot As Double
            Get
                Return _nVrcCosTot
            End Get
            Set(ByVal value As Double)
                _nVrcCosTot = value
            End Set
        End Property
        Public Property nTotUniReq As Double
            Get
                Return _nTotUniReq
            End Get
            Set(ByVal value As Double)
                _nTotUniReq = value
            End Set
        End Property
        Public Property nTotUniCns As Double
            Get
                Return _nTotUniCns
            End Get
            Set(ByVal value As Double)
                _nTotUniCns = value
            End Set
        End Property
        Public Property nVrcUni As Double
            Get
                Return _nVrcUni
            End Get
            Set(ByVal value As Double)
                _nVrcUni = value
            End Set
        End Property
        Public Property nCosUniReq As Double '30
            Get
                Return _nCosUniReq
            End Get
            Set(ByVal value As Double)
                _nCosUniReq = value
            End Set
        End Property
        Public Property nCosUniCns As Double
            Get
                Return _nCosUniCns
            End Get
            Set(ByVal value As Double)
                _nCosUniCns = value
            End Set
        End Property
        Public Property nVrcCosUni As Double '32
            Get
                Return _nVrcCosUni
            End Get
            Set(ByVal value As Double)
                _nVrcCosUni = value
            End Set
        End Property
        Public Property nPreVta As Double '
            Get
                Return _nPreVta
            End Get
            Set(ByVal value As Double)
                _nPreVta = value
            End Set
        End Property
        Public Property nPorGto As Double '
            Get
                Return _nPorGto
            End Get
            Set(ByVal value As Double)
                _nPorGto = value
            End Set
        End Property
        Public Property nPorIto As Double '35
            Get
                Return _nPorIto
            End Get
            Set(ByVal value As Double)
                _nPorIto = value
            End Set
        End Property



    End Class
#End Region

#Region "Terceros"
    Public Class eTEDMT
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sNomTer As String '2
        Private _sTipTer As String '3
        Private _sNitTer As String '4
        Private _sDigVer As String '5
        Private _sDirTer As String '6
        Private _sTel1Ter As String '7
        Private _sTel2Ter As String '8
        Private _sTelCll As String '9
        Private _sFax As String '10
        Private _sNomAlt As String '11
        Private _sCodGrpTer As String '12
        Private _sEmlTer As String '13
        Private _sNomCtc As String '14
        Private _sTipCtaCtb As String '15
        Private _sCodCtaCtb As String '16
        Private _sCndPag As String '17
        Private _sCodLstPre As String '18
        Private _nPorDto As Double '19
        Private _nLmtCre As Double '20
        Private _bAct As Boolean '21
        Private _bIna As Boolean '22
        Private _sCmn As String '23
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sNomTer As String '2
            Get
                Return _sNomTer
            End Get
            Set(ByVal value As String)
                _sNomTer = value
            End Set
        End Property
        Public Property sTipTer As String '3
            Get
                Return _sTipTer
            End Get
            Set(ByVal value As String)
                _sTipTer = value
            End Set
        End Property
        Public Property sNitTer As String '4
            Get
                Return _sNitTer
            End Get
            Set(ByVal value As String)
                _sNitTer = value
            End Set
        End Property
        Public Property sDigVer As String '5
            Get
                Return _sDigVer
            End Get
            Set(ByVal value As String)
                _sDigVer = value
            End Set
        End Property
        Public Property sDirTer As String '6
            Get
                Return _sDirTer
            End Get
            Set(ByVal value As String)
                _sDirTer = value
            End Set
        End Property
        Public Property sTel1Ter As String '7
            Get
                Return _sTel1Ter
            End Get
            Set(ByVal value As String)
                _sTel1Ter = value
            End Set
        End Property
        Public Property sTel2Ter As String '8
            Get
                Return _sTel2Ter
            End Get
            Set(ByVal value As String)
                _sTel2Ter = value
            End Set
        End Property
        Public Property sTelCll As String '9
            Get
                Return _sTelCll
            End Get
            Set(ByVal value As String)
                _sTelCll = value
            End Set
        End Property
        Public Property sFax As String '10
            Get
                Return _sFax
            End Get
            Set(ByVal value As String)
                _sFax = value
            End Set
        End Property
        Public Property sNomAlt As String '11
            Get
                Return _sNomAlt
            End Get
            Set(ByVal value As String)
                _sNomAlt = value
            End Set
        End Property
        Public Property sCodGrpTer As String '12
            Get
                Return _sCodGrpTer
            End Get
            Set(ByVal value As String)
                _sCodGrpTer = value
            End Set
        End Property
        Public Property sEmlTer As String '13
            Get
                Return _sEmlTer
            End Get
            Set(ByVal value As String)
                _sEmlTer = value
            End Set
        End Property
        Public Property sNomCtc As String '14
            Get
                Return _sNomCtc
            End Get
            Set(ByVal value As String)
                _sNomCtc = value
            End Set
        End Property
        Public Property sTipCtaCtb As String '15
            Get
                Return _sTipCtaCtb
            End Get
            Set(ByVal value As String)
                _sTipCtaCtb = value
            End Set
        End Property
        Public Property sCodCtaCtb As String '16
            Get
                Return _sCodCtaCtb
            End Get
            Set(ByVal value As String)
                _sCodCtaCtb = value
            End Set
        End Property
        Public Property sCndPag As String '17
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property sCodLstPre As String '18
            Get
                Return _sCodLstPre
            End Get
            Set(ByVal value As String)
                _sCodLstPre = value
            End Set
        End Property
        Public Property nPorDto As Double '19
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property nLmtCre As Double '20
            Get
                Return _nLmtCre
            End Get
            Set(ByVal value As Double)
                _nLmtCre = value
            End Set
        End Property
        Public Property bAct As Boolean '21
            Get
                Return _bAct
            End Get
            Set(ByVal value As Boolean)
                _bAct = value
            End Set
        End Property
        Public Property bIna As Boolean '22
            Get
                Return _bIna
            End Get
            Set(ByVal value As Boolean)
                _bIna = value
            End Set
        End Property
        Public Property sCmn As String '23
            Get
                Return _sCmn
            End Get
            Set(ByVal value As String)
                _sCmn = value
            End Set
        End Property
    End Class
    Public Class eTLDMT1
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sDirTer As String '2
        Private _sCiuTer As String '3
        Private _sDepTer As String '4
        Private _sPaiTer As String '5
        Private _bDirDfl As Boolean '6
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sDirTer As String '2
            Get
                Return _sDirTer
            End Get
            Set(ByVal value As String)
                _sDirTer = value
            End Set
        End Property
        Public Property sCiuTer As String '3
            Get
                Return _sCiuTer
            End Get
            Set(ByVal value As String)
                _sCiuTer = value
            End Set
        End Property
        Public Property sDepTer As String '4
            Get
                Return _sDepTer
            End Get
            Set(ByVal value As String)
                _sDepTer = value
            End Set
        End Property
        Public Property sPaiTer As String '5
            Get
                Return _sPaiTer
            End Get
            Set(ByVal value As String)
                _sPaiTer = value
            End Set
        End Property
        Public Property bDirDfl As Boolean '6
            Get
                Return _bDirDfl
            End Get
            Set(ByVal value As Boolean)
                _bDirDfl = value
            End Set
        End Property
    End Class
    Public Class eTLDMT2
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sCodRet As String '2
        Private _bAct As Boolean '3
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sCodRet As String '2
            Get
                Return _sCodRet
            End Get
            Set(ByVal value As String)
                _sCodRet = value
            End Set
        End Property

        Public Property bAct As Boolean '3
            Get
                Return _bAct
            End Get
            Set(ByVal value As Boolean)
                _bAct = value
            End Set
        End Property

    End Class
    Public Class eTLDMT3
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sCodIVA As String '2
        Private _bAct As Boolean '3
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sCodIVA As String '2
            Get
                Return _sCodIVA
            End Get
            Set(ByVal value As String)
                _sCodIVA = value
            End Set
        End Property

        Public Property bAct As Boolean '3
            Get
                Return _bAct
            End Get
            Set(ByVal value As Boolean)
                _bAct = value
            End Set
        End Property

    End Class
    Public Class eTLDMT4
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sMMTipDoc As String '2
        Private _sMMNomTer As String '3
        Private _sMMPriNom As String '4
        Private _sMMSegNom As String '5
        Private _sMMPriApe As String '6
        Private _sMMSegApe As String '7
        Private _sMMDirTer As String '8
        Private _sMMCodDep As String '9
        Private _sMMCodCiu As String '10
        Private _sMMCodPai As String '11
        Private _dMMFecRUT As String '12
        Private _sMMCodAcvPpl As String '13
        Private _sMMCodAcvAlt As String '14
        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTer As String '1
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sMMTipDoc As String '2
            Get
                Return _sMMTipDoc
            End Get
            Set(ByVal value As String)
                _sMMTipDoc = value
            End Set
        End Property
        Public Property sMMNomTer As String '3
            Get
                Return _sMMNomTer
            End Get
            Set(ByVal value As String)
                _sMMNomTer = value
            End Set
        End Property
        Public Property sMMPriNom As String '4
            Get
                Return _sMMPriNom
            End Get
            Set(ByVal value As String)
                _sMMPriNom = value
            End Set
        End Property
        Public Property sMMSegNom As String '5
            Get
                Return _sMMSegNom
            End Get
            Set(ByVal value As String)
                _sMMSegNom = value
            End Set
        End Property
        Public Property sMMPriApe As String '6
            Get
                Return _sMMPriApe
            End Get
            Set(ByVal value As String)
                _sMMPriApe = value
            End Set
        End Property
        Public Property sMMSegApe As String '7
            Get
                Return _sMMSegApe
            End Get
            Set(ByVal value As String)
                _sMMSegApe = value
            End Set
        End Property
        Public Property sMMDirTer As String '8
            Get
                Return _sMMDirTer
            End Get
            Set(ByVal value As String)
                _sMMDirTer = value
            End Set
        End Property
        Public Property sMMCodDep As String '9
            Get
                Return _sMMCodDep
            End Get
            Set(ByVal value As String)
                _sMMCodDep = value
            End Set
        End Property
        Public Property sMMCodCiu As String '10
            Get
                Return _sMMCodCiu
            End Get
            Set(ByVal value As String)
                _sMMCodCiu = value
            End Set
        End Property
        Public Property sMMCodPai As String '11
            Get
                Return _sMMCodPai
            End Get
            Set(ByVal value As String)
                _sMMCodPai = value
            End Set
        End Property
        Public Property dMMFecRUT As Date '12
            Get
                Return _dMMFecRUT
            End Get
            Set(ByVal value As Date)
                _dMMFecRUT = value
            End Set
        End Property
        Public Property sMMCodAcvPpl As String '13
            Get
                Return _sMMCodAcvPpl
            End Get
            Set(ByVal value As String)
                _sMMCodAcvPpl = value
            End Set
        End Property
        Public Property sMMCodAcvAlt As String '14
            Get
                Return _sMMCodAcvAlt
            End Get
            Set(ByVal value As String)
                _sMMCodAcvAlt = value
            End Set
        End Property

    End Class
    Public Class eATCOP
        Private _nId As Long '0
        Private _sCndPag As String '1
        Private _nNroDia As Integer '2
        Private _sCodFecVto As String '3

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCndPag As String '1
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property nNroDia As Integer '1
            Get
                Return _nNroDia
            End Get
            Set(ByVal value As Integer)
                _nNroDia = value
            End Set
        End Property

        Public Property sCodFecVto As String '1
            Get
                Return _sCodFecVto
            End Get
            Set(ByVal value As String)
                _sCodFecVto = value
            End Set
        End Property
    End Class
#End Region

#Region "Consultas"
    Public Class ePEODP_QCodDoc
        Private _nId As Long '0
        Private _sCodDoc As String '1

        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property

        Public Property sCodDoc As String '1
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
    End Class
    Public Class eQConSdoFin
        Private _nId As Long '0
        Private _sCodAlm As String '0
        Private _sCodGrp As String '1
        Private _sCodItm As String '2
        Private _sNomItm As String '3
        Private _bItmAct As Boolean '4
        Private _bIndCan As Boolean '5
        Private _bIndCos As Boolean '6
        Private _nSdoFinUni As Double '7
        Private _nSdoFinPes As Double '8
        Public Property nId As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodAlm As String '1
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property sCodGrp As String '2
            Get
                Return _sCodGrp
            End Get
            Set(ByVal value As String)
                _sCodGrp = value
            End Set
        End Property
        Public Property sCodItm As String '3
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sNomItm As String '4
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property bItmAct As Boolean '5
            Get
                Return _bItmAct
            End Get
            Set(ByVal value As Boolean)
                _bItmAct = value
            End Set
        End Property
        Public Property bIndCan As Boolean '6
            Get
                Return _bIndCan
            End Get
            Set(ByVal value As Boolean)
                _bIndCan = value
            End Set
        End Property
        Public Property bIndCos As Boolean '7
            Get
                Return _bIndCos
            End Get
            Set(ByVal value As Boolean)
                _bIndCos = value
            End Set
        End Property
        Public Property nSdoFinUni As Double '8
            Get
                Return _nSdoFinUni
            End Get
            Set(ByVal value As Double)
                _nSdoFinUni = value
            End Set
        End Property
        Public Property nSdoFinPes As Double '9
            Get
                Return _nSdoFinPes
            End Get
            Set(ByVal value As Double)
                _nSdoFinPes = value
            End Set
        End Property
    End Class
#End Region

#Region "Medios magnéticos"
    Public Class eWTCAE
        Private _nId As Long '0
        Private _sCodAce As String '1
        Private _sNomAce As String '2

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodAce As String '1
            Get
                Return _sCodAce
            End Get
            Set(ByVal value As String)
                _sCodAce = value
            End Set
        End Property
        Public Property sNomAce As String '1
            Get
                Return _sNomAce
            End Get
            Set(ByVal value As String)
                _sNomAce = value
            End Set
        End Property
    End Class
    Public Class eWTCIU
        Private _nId As Long '0
        Private _sMMCodDep As String '1
        Private _sMMCodCiu As String '2
        Private _sMMNomCiu As String '3

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sMMCodDep As String '1
            Get
                Return _sMMCodDep
            End Get
            Set(ByVal value As String)
                _sMMCodDep = value
            End Set
        End Property
        Public Property sMMCodCiu As String '1
            Get
                Return _sMMCodCiu
            End Get
            Set(ByVal value As String)
                _sMMCodCiu = value
            End Set
        End Property
        Public Property sMMNomCiu As String '1
            Get
                Return _sMMNomCiu
            End Get
            Set(ByVal value As String)
                _sMMNomCiu = value
            End Set
        End Property
    End Class
    Public Class eWTDEP
        Private _nId As Long '0
        Private _sMMCodDep As String '1
        Private _sMMNomDep As String '2

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sMMCodDep As String '1
            Get
                Return _sMMCodDep
            End Get
            Set(ByVal value As String)
                _sMMCodDep = value
            End Set
        End Property
        Public Property sMMNomDep As String '1
            Get
                Return _sMMNomDep
            End Get
            Set(ByVal value As String)
                _sMMNomDep = value
            End Set
        End Property
    End Class
    Public Class eWTPAI
        Private _nId As Long '0
        Private _sMMCodPai As String '1
        Private _sMMNomPai As String '2

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sMMCodPai As String '1
            Get
                Return _sMMCodPai
            End Get
            Set(ByVal value As String)
                _sMMCodPai = value
            End Set
        End Property
        Public Property sMMNomPai As String '1
            Get
                Return _sMMNomPai
            End Get
            Set(ByVal value As String)
                _sMMNomPai = value
            End Set
        End Property

    End Class
    Public Class eWTTID
        Private _nId As Long '0
        Private _sCodTipDoc As String '1
        Private _sNomDoc As String '2

        Public Property nID As Long '0
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
            End Set
        End Property
        Public Property sCodTipDoc As String '1
            Get
                Return _sCodTipDoc
            End Get
            Set(ByVal value As String)
                _sCodTipDoc = value
            End Set
        End Property
        Public Property sNomDoc As String '1
            Get
                Return _sNomDoc
            End Get
            Set(ByVal value As String)
                _sNomDoc = value
            End Set
        End Property
    End Class

#End Region
End Class



