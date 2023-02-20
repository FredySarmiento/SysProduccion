Public Class clpEstructuras
    Public Class eAPDGV
        Private _nId As Long '0
        Private _sCodFrm As String '1
        Private _sCodDgv As String '2
        Private _nCol As Integer '3
        Private _nNroCol As Integer '4
        Private _sTitCol As String '5
        Private _sTipCol As String '6'
        Private _bColxDef As Boolean '7
        Private _bVisible As Boolean '8
        Private _bReadOnly As Boolean '9
        Private _bColPor As Boolean '10
        Private _nColNom As Integer '11
        Private _nColVlr As Integer '12
        Private _sNomDat As String '13
        Private _bDatReq As Boolean '14
        Private _sRglVdaDat As String '15
        Private _sCodErrDat As String '16
        Private _sNomTblVda As String '17
        Private _sRglVdaEOF As String '18
        Private _sCodErrEOF As String '19
        Private _sDesOpe As String '20
        Private _nColRes As Integer '21
        Private _sCodErrOpe As String '22
        Private _nColVda As Integer '23
        Private _sRglVdaCol As String '24
        Private _sCodErrCol As String '25
        Private _sDatBas As String '26
        Private _bColTot As Boolean '27
        Private _bGQLst As Boolean '28
        Private _sCodErrEOF1 As String '29
        Private _nColCtaInv As Integer '30
        Private _nColCosVta As Integer '31 
        Private _sTblOriDat As String '32
        Private _nColDocBas As Integer '33
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
        Public Property nCol As Integer '3
            Get
                Return _nCol
            End Get
            Set(ByVal value As Integer)
                _nCol = value
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
        Public Property sRglVdaEOF As String '18
            Get
                Return _sRglVdaEOF
            End Get
            Set(ByVal value As String)
                _sRglVdaEOF = value
            End Set
        End Property
        Public Property sCodErrEOF As String '19
            Get
                Return _sCodErrEOF
            End Get
            Set(ByVal value As String)
                _sCodErrEOF = value
            End Set
        End Property
        Public Property sDesOpe As String '20
            Get
                Return _sDesOpe
            End Get
            Set(ByVal value As String)
                _sDesOpe = value
            End Set
        End Property
        Public Property nColRes As Integer '21
            Get
                Return _nColRes
            End Get
            Set(ByVal value As Integer)
                _nColRes = value
            End Set
        End Property
        Public Property sCodErrOpe As String '22
            Get
                Return _sCodErrOpe
            End Get
            Set(ByVal value As String)
                _sCodErrOpe = value
            End Set
        End Property
        Public Property nColVda As Integer '23
            Get
                Return _nColVda
            End Get
            Set(ByVal value As Integer)
                _nColVda = value
            End Set
        End Property
        Public Property sRglVdaCol As String '24
            Get
                Return _sRglVdaCol
            End Get
            Set(ByVal value As String)
                _sRglVdaCol = value
            End Set
        End Property
        Public Property sCodErrCol As String '25
            Get
                Return _sCodErrCol
            End Get
            Set(ByVal value As String)
                _sCodErrCol = value
            End Set
        End Property
        Public Property sDatBas As String '26
            Get
                Return _sDatBas
            End Get
            Set(ByVal value As String)
                _sDatBas = value
            End Set
        End Property
        Public Property bColTot As Boolean '27
            Get
                Return _bColTot
            End Get
            Set(ByVal value As Boolean)
                _bColTot = value
            End Set
        End Property
        Public Property bGQLst As Boolean '28
            Get
                Return _bGQLst
            End Get
            Set(ByVal value As Boolean)
                _bGQLst = value
            End Set
        End Property
        Public Property sCodErrEOF1 As String '29
            Get
                Return _sCodErrEOF1
            End Get
            Set(ByVal value As String)
                _sCodErrEOF1 = value
            End Set
        End Property
        Public Property nColCtaInv As Integer '30
            Get
                Return _nColCtaInv
            End Get
            Set(ByVal value As Integer)
                _nColCtaInv = value
            End Set
        End Property
        Public Property nColCosVta As Integer '31
            Get
                Return _nColCosVta
            End Get
            Set(ByVal value As Integer)
                _nColCosVta = value
            End Set
        End Property
        Public Property sTblOriDat As String '32
            Get
                Return _sTblOriDat
            End Get
            Set(ByVal value As String)
                _sTblOriDat = value
            End Set
        End Property
        Public Property nColDocBas As Integer '33
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
    End Class
    Public Class eAPEND
        Private _sCodDoc As String '0
        Private _sCodSer As String '1
        Private _sDesDoc As String '2
        Private _sTipMov As String '3
        Private _nNroIni As Long '4
        Private _nNroSig As Long '5
        Private _nNroFin As Long '6
        Private _sClsDoc As Long '6

        Public Property sCodDoc As String '0
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sCodSer As String '1
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property sDesDoc As String '2
            Get
                Return _sDesDoc
            End Get
            Set(ByVal value As String)
                _sDesDoc = value
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
        Public Property nNroIni As Long '4
            Get
                Return _nNroIni
            End Get
            Set(ByVal value As Long)
                _nNroIni = value
            End Set
        End Property
        Public Property nNroSig As Long '5
            Get
                Return _nNroSig
            End Get
            Set(ByVal value As Long)
                _nNroSig = value
            End Set
        End Property
        Public Property nNroFin As Long '6
            Get
                Return _nNroFin
            End Get
            Set(ByVal value As Long)
                _nNroFin = value
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
    Public Class eAPLND1
        Private _sCodDoc As String '0
        Private _sCodSer As String '1
        Private _nNroIni As Long '2
        Private _nNroSig As Long '3
        Private _nNroFin As Long '4

        Public Property sCodDoc As String '0
            Get
                Return _sCodDoc
            End Get
            Set(ByVal value As String)
                _sCodDoc = value
            End Set
        End Property
        Public Property sCodSer As String '1
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
        Public Property nNroIni As Long '2
            Get
                Return _nNroIni
            End Get
            Set(ByVal value As Long)
                _nNroIni = value
            End Set
        End Property
        Public Property nNroSig As Long '3
            Get
                Return _nNroSig
            End Get
            Set(ByVal value As Long)
                _nNroSig = value
            End Set
        End Property
        Public Property nNroFin As Long '4
            Get
                Return _nNroFin
            End Get
            Set(ByVal value As Long)
                _nNroFin = value
            End Set
        End Property
    End Class
    Public Class eATCCO
        Private _nId As Long '0
        Private _sCodCco As String '1
        Private _sNomCco As String '2
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
    Public Class eATVEN
        Private _nId As Long '0
        Private _sCodVen As String '1
        Private _sNomVen As String '2
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
    End Class
    Public Class eFTPUC
        Private _nId As Long '0
        Private _sCodCta As String '1
        Private _sNomCta As String '2
        Private _nSdoFinCta As Double '3
        Private _nSdoIniCta As Double '4
        Private _sNivCta As String '5
        Private _sCodCtaSup As String '6
        Private _bCtaBlq As Boolean '7
        Private _bCtaIac As Boolean '8
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
        Public Property sNomCta As String '2
            Get
                Return _sNomCta
            End Get
            Set(ByVal value As String)
                _sNomCta = value
            End Set
        End Property
        Public Property nSdoFinCta As Double '3
            Get
                Return _nSdoFinCta
            End Get
            Set(ByVal value As Double)
                _nSdoFinCta = value
            End Set
        End Property
        Public Property nSdoIniCta As Double '4
            Get
                Return _nSdoIniCta
            End Get
            Set(ByVal value As Double)
                _nSdoIniCta = value
            End Set
        End Property

        Public Property sNivCta As String '5
            Get
                Return _sNivCta
            End Get
            Set(ByVal value As String)
                _sNivCta = value
            End Set
        End Property
        Public Property sCodCtaSup As String '6
            Get
                Return _sCodCtaSup
            End Get
            Set(ByVal value As String)
                _sCodCtaSup = value
            End Set
        End Property

        Public Property bCtaBlq As Boolean '7
            Get
                Return _bCtaBlq
            End Get
            Set(ByVal value As Boolean)
                _bCtaBlq = value
            End Set
        End Property
        Public Property bCtaIac As Boolean '8
            Get
                Return _bCtaIac
            End Get
            Set(ByVal value As Boolean)
                _bCtaIac = value
            End Set
        End Property

    End Class
    Public Class eGEMOV
        Private _nID As Long       '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long   '2
        Private _sEstDoc As String '3
        Private _sTipMov As String '4
        Private _dFecCtb As Date   '5
        Private _dFecDoc As Date   '6
        Private _dFecVto As Date   '7
        Private _dFecSys As Date   '8
        Private _sCodTer As String '9 
        Private _sDesTer As String '10
        Private _nPorDto As Double '11
        Private _sAlmOri As String '12
        Private _sDocRef As String '13
        Private _nTotDtoLin As Double '14
        Private _nTotTot As Double '15
        Private _nTotIvaCom As Double '16
        Private _nTotIvaVta As Double '17
        Private _nVlrTotLin As Double '18
        Private _sCodCte As String '19
        Private _nNroCte As Long '20
        Private _sCndPag As String '21
        Private _sClsDoc As String '22
        Private _sTipDoc As String '23'
        Private _sCodVen As String '24'
        Private _sCodSer As String '25'
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
        Public Property sTipMov As String '4
            Get
                Return _sTipMov
            End Get
            Set(ByVal value As String)
                _sTipMov = value
            End Set
        End Property
        Public Property dFecCtb As Date '5
            Get
                Return _dFecCtb
            End Get
            Set(ByVal value As Date)
                _dFecCtb = value
            End Set
        End Property
        Public Property dFecDoc As Date '6
            Get
                Return _dFecDoc
            End Get
            Set(ByVal value As Date)
                _dFecDoc = value
            End Set
        End Property
        Public Property dFecVto As Date '7
            Get
                Return _dFecVto
            End Get
            Set(ByVal value As Date)
                _dFecVto = value
            End Set
        End Property
        Public Property dFecSys As Date '8
            Get
                Return _dFecSys
            End Get
            Set(ByVal value As Date)
                _dFecSys = value
            End Set
        End Property
        Public Property sCodTer As String '9
            Get
                Return _sCodTer
            End Get
            Set(ByVal value As String)
                _sCodTer = value
            End Set
        End Property
        Public Property sDesTer As String '10
            Get
                Return _sDesTer
            End Get
            Set(ByVal value As String)
                _sDesTer = value
            End Set
        End Property
        Public Property nPorDto As Double '11
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property sAlmOri As String '12
            Get
                Return _sAlmOri
            End Get
            Set(ByVal value As String)
                _sAlmOri = value
            End Set
        End Property
        Public Property sDocRef As String '13
            Get
                Return _sDocRef
            End Get
            Set(ByVal value As String)
                _sDocRef = value
            End Set
        End Property
        Public Property nTotDtoLin As Double '14
            Get
                Return _nTotDtoLin
            End Get
            Set(ByVal value As Double)
                _nTotDtoLin = value
            End Set
        End Property
        Public Property nTotTot As Double '15
            Get
                Return _nTotTot
            End Get
            Set(ByVal value As Double)
                _nTotTot = value
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
        Public Property nTotIvaVta As Double '15
            Get
                Return _nTotIvaVta
            End Get
            Set(ByVal value As Double)
                _nTotIvaVta = value
            End Set
        End Property
        Public Property nVlrTotLin As Double '18
            Get
                Return _nVlrTotLin
            End Get
            Set(ByVal value As Double)
                _nVlrTotLin = value
            End Set
        End Property
        Public Property sCodCte As String '19
            Get
                Return _sCodCte
            End Get
            Set(ByVal value As String)
                _sCodCte = value
            End Set
        End Property
        Public Property nNroCte As Long '20
            Get
                Return _nNroCte
            End Get
            Set(ByVal value As Long)
                _nNroCte = value
            End Set
        End Property
        Public Property sCndPag As String '21
            Get
                Return _sCndPag
            End Get
            Set(ByVal value As String)
                _sCndPag = value
            End Set
        End Property
        Public Property sClsDoc As String '22
            Get
                Return _sClsDoc
            End Get
            Set(ByVal value As String)
                _sClsDoc = value
            End Set
        End Property
        Public Property sTipDoc As String '23
            Get
                Return _sTipDoc
            End Get
            Set(ByVal value As String)
                _sTipDoc = value
            End Set
        End Property
        Public Property sCodVen As String '24
            Get
                Return _sCodVen
            End Get
            Set(ByVal value As String)
                _sCodVen = value
            End Set
        End Property
        Public Property sCodSer As String '25
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
    End Class
    Public Class eGLMOV1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2 
        Private _sTipMov As String '3
        Private _sCodItm As String '4
        Private _sDesItm As String '5
        Private _sCodAlm As String '6
        Private _nCanItm As Double '7 
        Private _sUniMedInv As String '8
        Private _nPreUni As Double '9
        Private _nPorDto As Double '10
        Private _nVlrDto As Double '11
        Private _nPreDto As Double '12
        Private _nVlrDtoLin As Double '13
        Private _nVlrTot As Double '14
        Private _sCodIva As String '15
        Private _nPorIva As Double '16
        Private _nVlrIva As Double '17
        Private _nVlrIvaLin As Double '18
        Private _nPreBru As Double '19
        Private _nTotLin As Double '20
        Private _nPorCms As Double '21
        Private _sCodCco As String '22
        Private _sTipLIM As String '23
        Private _sCodVen As String '24
        Private _sCodDocBas As String '25
        Private _nNroDocBas As Long '26
        Private _nLinBas As Long '27
        Private _sCodPdo As String '28
        Private _sCtaInv As String '29
        Private _bSolIto As Boolean '30
        Private _sCtaCosVta As String '31
        Private _bItmBlq As Boolean '32
        Private _sCodSer As String '33
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
        Public Property sCodItm As String '4
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sDesItm As String '5
            Get
                Return _sDesItm
            End Get
            Set(ByVal value As String)
                _sDesItm = value
            End Set
        End Property
        Public Property sCodAlm As String '6
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nCanItm As Double '7
            Get
                Return _nCanItm
            End Get
            Set(ByVal value As Double)
                _nCanItm = value
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
        Public Property nPreUni As Double '9
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nPorDto As Double '10
            Get
                Return _nPorDto
            End Get
            Set(ByVal value As Double)
                _nPorDto = value
            End Set
        End Property
        Public Property nVlrDto As Double '11
            Get
                Return _nVlrDto
            End Get
            Set(ByVal value As Double)
                _nVlrDto = value
            End Set
        End Property
        Public Property nPreDto As Double '12
            Get
                Return _nPreDto
            End Get
            Set(ByVal value As Double)
                _nPreDto = value
            End Set
        End Property
        Public Property nVlrDtoLin As Double '13
            Get
                Return _nVlrDtoLin
            End Get
            Set(ByVal value As Double)
                _nVlrDtoLin = value
            End Set
        End Property
        Public Property nVlrTot As Double '14
            Get
                Return _nVlrTot
            End Get
            Set(ByVal value As Double)
                _nVlrTot = value
            End Set
        End Property
        Public Property sCodIva As String '15
            Get
                Return _sCodIva
            End Get
            Set(ByVal value As String)
                _sCodIva = value
            End Set
        End Property
        Public Property nPorIva As Double '16
            Get
                Return _nPorIva
            End Get
            Set(ByVal value As Double)
                _nPorIva = value
            End Set
        End Property
        Public Property nVlrIva As Double '17
            Get
                Return _nVlrIva
            End Get
            Set(ByVal value As Double)
                _nVlrIva = value
            End Set
        End Property
        Public Property nVlrIvaLin As Double '18
            Get
                Return _nVlrIvaLin
            End Get
            Set(ByVal value As Double)
                _nVlrIvaLin = value
            End Set
        End Property
        Public Property nPreBru As Double '19
            Get
                Return _nPreBru
            End Get
            Set(ByVal value As Double)
                _nPreBru = value
            End Set
        End Property
        Public Property nTotLin As Double '20
            Get
                Return _nTotLin
            End Get
            Set(ByVal value As Double)
                _nTotLin = value
            End Set
        End Property
        Public Property nPorCms As Double '21
            Get
                Return _nPorCms
            End Get
            Set(ByVal value As Double)
                _nPorCms = value
            End Set
        End Property
        Public Property sCodCco As String '22
            Get
                Return _sCodCco
            End Get
            Set(ByVal value As String)
                _sCodCco = value
            End Set
        End Property
        Public Property sTipLIM As String '23
            Get
                Return _sTipLIM
            End Get
            Set(ByVal value As String)
                _sTipLIM = value
            End Set
        End Property
        Public Property sCodVen As String '24
            Get
                Return _sCodVen
            End Get
            Set(ByVal value As String)
                _sCodVen = value
            End Set
        End Property
        Public Property sCodDocBas As String '25
            Get
                Return _sCodDocBas
            End Get
            Set(ByVal value As String)
                _sCodDocBas = value
            End Set
        End Property
        Public Property nNroDocBas As Long '26
            Get
                Return _nNroDocBas
            End Get
            Set(ByVal value As Long)
                _nNroDocBas = value
            End Set
        End Property
        Public Property nLinBas As Long '27
            Get
                Return _nLinBas
            End Get
            Set(ByVal value As Long)
                _nLinBas = value
            End Set
        End Property
        Public Property sCodPdo As String '28
            Get
                Return _sCodPdo
            End Get
            Set(ByVal value As String)
                _sCodPdo = value
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
        Public Property bSolIto As Boolean '30
            Get
                Return _bSolIto
            End Get
            Set(ByVal value As Boolean)
                _bSolIto = value
            End Set
        End Property
        Public Property sCtaCosVta As String '31
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
            End Set
        End Property
        Public Property bItmBlq As Boolean '32
            Get
                Return _bItmBlq
            End Get
            Set(ByVal value As Boolean)
                _bItmBlq = value
            End Set
        End Property
        Public Property sCodSer As String '33
            Get
                Return _sCodSer
            End Get
            Set(ByVal value As String)
                _sCodSer = value
            End Set
        End Property
    End Class
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
        Private _sCtaInv As String '9
        Private _sCtaCosVta As String '10
        Private _sCtaTrs As String '11
        Private _sCtaIng As String '12
        Private _sCtaDevVta As String '13
        Private _sCtaGto As String '14
        Private _sCtaDot As String '15
        Private _sCtaDifPre As String '16
        Private _sCtaDsv As String '17
        Private _sCtaRev As String '18
        Private _sCtaAumInv As String '19
        Private _sCtaRedInv As String '20
        Private _sCtaCom As String '21
        Private _sCtaDevCom As String '22
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
        Public Property sCtaGto As String '14
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
            End Set
        End Property
        Public Property sCtaDot As String '15
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String '16
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaDsv As String '17
            Get
                Return _sCtaDsv
            End Get
            Set(ByVal value As String)
                _sCtaDsv = value
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
    End Class
    Public Class eIELDMI1
        Private _eIEDMI As New eIEDMI '0
        Private _eILDMI1 As New eILDMI1 '0
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
    Public Class ePEODP
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sEstOdp As String '3
        Private _sCodItm As String '4
        Private _nCanOdp As Double '5
        Private _sCodAlm As String '6
        Private _dFecEmi As Date '7
        Private _dFecIni As Date '8
        Private _dFecFin As Date '9
        Private _sNomItm As String '10
        Private _nSdoInv As Double '11
        Private _sUniMedInv As String '12
        Private _nPreUni As Double '13 
        Private _nSdoAlm As Double '14 
        Private _sCtaInv As String '15

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
        Public Property sEstOdp As String '3
            Get
                Return _sEstOdp
            End Get
            Set(ByVal value As String)
                _sEstOdp = value
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
        Public Property sCodAlm As String '6
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property dFecEmi As Date '7
            Get
                Return _dFecEmi
            End Get
            Set(ByVal value As Date)
                _dFecEmi = value
            End Set
        End Property
        Public Property dFecIni As Date '8
            Get
                Return _dFecIni
            End Get
            Set(ByVal value As Date)
                _dFecIni = value
            End Set
        End Property
        Public Property dFecFin As Date '9
            Get
                Return _dFecFin
            End Get
            Set(ByVal value As Date)
                _dFecFin = value
            End Set
        End Property
        Public Property sNomItm As String '10
            Get
                Return _sNomItm
            End Get
            Set(ByVal value As String)
                _sNomItm = value
            End Set
        End Property
        Public Property nSdoInv As Double '11
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property sUniMedInv As String '12
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nPreUni As Double '13
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nSdoAlm As Double '14
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property sCtaInv As String '15
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property

    End Class
    Public Class ePLODP1
        Private _nId As Long '0
        Private _sCodDoc As String '1
        Private _nNroDoc As Long '2
        Private _sCodItm As String '3
        Private _sCodCmt As String '4
        Private _nCanCmt As Double '5
        Private _nCanReq As Double '6
        Private _nCanCns As Double '7
        Private _sCodAlm As String '8
        Private _sCodAlmCns As String '8
        Private _sCodCmtAlt As String '9
        Private _sNomCmt As String '10
        Private _nSdoInv As Double '11
        Private _sUniMedInv As String '12
        Private _nPreUni As Double '13 
        Private _nSdoAlm As Double '14 
        Private _sCtaInv As String '15
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
        Public Property sCodItm As String '3
            Get
                Return _sCodItm
            End Get
            Set(ByVal value As String)
                _sCodItm = value
            End Set
        End Property
        Public Property sCodCmt As String '4
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property nCanCmt As Double '5
            Get
                Return _nCanCmt
            End Get
            Set(ByVal value As Double)
                _nCanCmt = value
            End Set
        End Property
        Public Property nCanReq As Double '6
            Get
                Return _nCanReq
            End Get
            Set(ByVal value As Double)
                _nCanReq = value
            End Set
        End Property
        Public Property nCanCns As Double '7
            Get
                Return _nCanCns
            End Get
            Set(ByVal value As Double)
                _nCanCns = value
            End Set
        End Property
        Public Property sCodAlmCns As String '8
            Get
                Return _sCodAlmCns
            End Get
            Set(ByVal value As String)
                _sCodAlmCns = value
            End Set
        End Property
        Public Property sCodCmtAlt As String '9
            Get
                Return _sCodCmtAlt
            End Get
            Set(ByVal value As String)
                _sCodCmtAlt = value
            End Set
        End Property
        Public Property sNomCmt As String '10
            Get
                Return _sNomCmt
            End Get
            Set(ByVal value As String)
                _sNomCmt = value
            End Set
        End Property
        Public Property nSdoInv As Double '11
            Get
                Return _nSdoInv
            End Get
            Set(ByVal value As Double)
                _nSdoInv = value
            End Set
        End Property
        Public Property sUniMedInv As String '12
            Get
                Return _sUniMedInv
            End Get
            Set(ByVal value As String)
                _sUniMedInv = value
            End Set
        End Property
        Public Property nPreUni As Double '13
            Get
                Return _nPreUni
            End Get
            Set(ByVal value As Double)
                _nPreUni = value
            End Set
        End Property
        Public Property nSdoAlm As Double '14
            Get
                Return _nSdoAlm
            End Get
            Set(ByVal value As Double)
                _nSdoAlm = value
            End Set
        End Property
        Public Property sCtaInv As String '15
            Get
                Return _sCtaInv
            End Get
            Set(ByVal value As String)
                _sCtaInv = value
            End Set
        End Property
    End Class
    Public Class ePLODP2
        Private _nId As Long
        Private _sCodDoc As String
        Private _nNroDoc As Long
        Private _sCodItm As String
        Private _sCodOpe As String
        Private _nTieOpe As Double
        Private _nTieReq As Double
        Private _nTieCns As Double
        Public Property nId As Long
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
        Public Property nNroDoc As Long
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
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
        Public Property sCodOpe As String
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property nTieOpe As Double
            Get
                Return _nTieOpe
            End Get
            Set(ByVal value As Double)
                _nTieOpe = value
            End Set
        End Property
        Public Property nTieReq As Double
            Get
                Return _nTieReq
            End Get
            Set(ByVal value As Double)
                _nTieReq = value
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
    End Class
    Public Class ePLODP3
        Private _nId As Long
        Private _sCodDoc As String
        Private _nNroDoc As Long
        Private _sCodItm As String
        Private _sCodCIF As String
        Private _nVlrCIF As Double
        Private _nVlrReq As Double
        Private _nVlrCns As Double
        Public Property nId As Long
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
        Public Property nNroDoc As Long
            Get
                Return _nNroDoc
            End Get
            Set(ByVal value As Long)
                _nNroDoc = value
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
        Public Property sCodCIF As String
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property nVlrCIF As Double
            Get
                Return _nVlrCIF
            End Get
            Set(ByVal value As Double)
                _nVlrCIF = value
            End Set
        End Property
        Public Property nVlrReq As Double
            Get
                Return _nVlrReq
            End Get
            Set(ByVal value As Double)
                _nVlrReq = value
            End Set
        End Property
        Public Property nVlrCns As Double
            Get
                Return _nVlrCns
            End Get
            Set(ByVal value As Double)
                _nVlrCns = value
            End Set
        End Property
    End Class
    Public Class ePELIM
        Private _nId As Long
        Private _sCodItm As String
        Private _nCanUniPro As Double
        Private _sUniMedPro As String
        Private _sTipLIM As String
        Private _sCodAlm As String
        Private _nPesItm As Double
        Private _nPorItm As Double
        Public Property nId As Long
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
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
        Public Property nCanUniPro As Double
            Get
                Return _nCanUniPro
            End Get
            Set(ByVal value As Double)
                _nCanUniPro = value
            End Set
        End Property
        Public Property sUniMedPro As String
            Get
                Return _sUniMedPro
            End Get
            Set(ByVal value As String)
                _sUniMedPro = value
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
        Public Property sCodAlm As String
            Get
                Return _sCodAlm
            End Get
            Set(ByVal value As String)
                _sCodAlm = value
            End Set
        End Property
        Public Property nPesItm As Double
            Get
                Return _nPesItm
            End Get
            Set(ByVal value As Double)
                _nPesItm = value
            End Set
        End Property
        Public Property nPorItm As Double
            Get
                Return _nPorItm
            End Get
            Set(ByVal value As Double)
                _nPorItm = value
            End Set
        End Property
    End Class
    Public Class ePLLIM1
        Private _nId As Long
        Private _sCodItm As String
        Private _sCodCmt As String
        Private _nCanCmt As Double
        Private _nPesCmt As Double
        Private _nPorCmt As Double
        Private _sCodAlmCns As String
        Private _sUniMedInv As String
        Public Property nId As Long
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
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
        Public Property sCodCmt As String
            Get
                Return _sCodCmt
            End Get
            Set(ByVal value As String)
                _sCodCmt = value
            End Set
        End Property
        Public Property nCanCmt As Double
            Get
                Return _nCanCmt
            End Get
            Set(ByVal value As Double)
                _nCanCmt = value
            End Set
        End Property
        Public Property nPesCmt As Double
            Get
                Return _nPesCmt
            End Get
            Set(ByVal value As Double)
                _nPesCmt = value
            End Set
        End Property
        Public Property nPorCmt As Double
            Get
                Return _nPorCmt
            End Get
            Set(ByVal value As Double)
                _nPorCmt = value
            End Set
        End Property
        Public Property sCodAlmCns As String
            Get
                Return _sCodAlmCns
            End Get
            Set(ByVal value As String)
                _sCodAlmCns = value
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
    End Class
    Public Class ePLLIM2
        Private _nId As Long
        Private _sCodItm As String
        Private _sCodOpe As String
        Private _nTieOpe As Double
        Public Property nId As Long
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
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
        Public Property sCodOpe As String
            Get
                Return _sCodOpe
            End Get
            Set(ByVal value As String)
                _sCodOpe = value
            End Set
        End Property
        Public Property nTieOpe As Double
            Get
                Return _nTieOpe
            End Get
            Set(ByVal value As Double)
                _nTieOpe = value
            End Set
        End Property
    End Class
    Public Class ePLLIM3
        Private _nId As Long
        Private _sCodItm As String
        Private _sCodCIF As String
        Private _nVlrCIF As Double
        Public Property nId As Long
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
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
        Public Property sCodCIF As String
            Get
                Return _sCodCIF
            End Get
            Set(ByVal value As String)
                _sCodCIF = value
            End Set
        End Property
        Public Property nVlrCIF As Double
            Get
                Return _nVlrCIF
            End Get
            Set(ByVal value As Double)
                _nVlrCIF = value
            End Set
        End Property
    End Class
    Public Class eITALM
        Private _nId As Long
        Private _sCodAlm As String
        Private _sNomAlm As String
        Private _sCtaInv As String
        Private _sCtaCosVta As String
        Public Property nId As Long
            Get
                Return _nId
            End Get
            Set(ByVal value As Long)
                _nId = value
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
        Public Property sNomAlm As String
            Get
                Return _sNomAlm
            End Get
            Set(ByVal value As String)
                _sNomAlm = value
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
        Public Property sCtaCosVta As String
            Get
                Return _sCtaCosVta
            End Get
            Set(ByVal value As String)
                _sCtaCosVta = value
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
        Private _sCtaCos As String '10
        Private _sCtaGto As String '11
        Private _sCtaIng As String '12
        Private _sCtaDot As String '13
        Private _sCtaDifPre As String '14
        Private _sCtaDsv As String '15
        Private _sCtaDev As String '16
        Private _sCtaRev As String '17
        Private _nId1 As Long '18
        Private _sCodAlm1 As String '19
        Private _sNomAlm1 As String '20
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
        Public Property sCtaCos As String '10
            Get
                Return _sCtaCos
            End Get
            Set(ByVal value As String)
                _sCtaCos = value
            End Set
        End Property
        Public Property sCtaGto As String '11
            Get
                Return _sCtaGto
            End Get
            Set(ByVal value As String)
                _sCtaGto = value
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
        Public Property sCtaDot As String '13
            Get
                Return _sCtaDot
            End Get
            Set(ByVal value As String)
                _sCtaDot = value
            End Set
        End Property
        Public Property sCtaDifPre As String '14
            Get
                Return _sCtaDifPre
            End Get
            Set(ByVal value As String)
                _sCtaDifPre = value
            End Set
        End Property
        Public Property sCtaDsv As String '15
            Get
                Return _sCtaDsv
            End Get
            Set(ByVal value As String)
                _sCtaDsv = value
            End Set
        End Property
        Public Property sCtaDev As String '16
            Get
                Return _sCtaDev
            End Get
            Set(ByVal value As String)
                _sCtaDev = value
            End Set
        End Property
        Public Property sCtaRev As String '17
            Get
                Return _sCtaRev
            End Get
            Set(ByVal value As String)
                _sCtaRev = value
            End Set
        End Property
        Public Property nId1 As Long '18
            Get
                Return _nId1
            End Get
            Set(ByVal value As Long)
                _nId1 = value
            End Set
        End Property
        Public Property sCodAlm1 As String
            Get
                Return _sCodAlm1
            End Get
            Set(ByVal value As String)
                _sCodAlm1 = value
            End Set
        End Property
        Public Property sNomAlm1 As String
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
    Public Class eTEDMT
        Private _nId As Long '0
        Private _sCodTer As String '1
        Private _sNomTer As String '2
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
    End Class
  
End Class



