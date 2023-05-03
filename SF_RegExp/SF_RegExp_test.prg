PROCEDURE Test_Prop		&& Example to use of properties
 LOCAL;
  lcx      AS STRING,;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 loRegExp.Compiled = .T.
 ?m.loRegExp.Compiled
 lcx              = "xx"
 loRegExp.PATTERN = m.lcx
 ?m.loRegExp.PATTERN

ENDPROC &&Test_Prop

PROCEDURE Test_Escape		&& Example to use of (Un)Esscape methods
 LOCAL;
  lcTemp   AS STRING,;
  lcTemp1  AS STRING,;
  lcTemp2  AS STRING,;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 lcTemp = "*+.bla?"
*Show Escape / UnEscape
 lcTemp1 = loRegExp.ESCAPE(m.lcTemp)
 lcTemp2 = loRegExp.UnEscape(m.lcTemp1)
 ?m.lcTemp,m.lcTemp1,m.lcTemp2,m.lcTemp=m.lcTemp2,loRegExp.UnEscape_Like(m.lcTemp1)

*Show Escape_Like / UnEscape_Like
 lcTemp1 = loRegExp.Escape_Like(m.lcTemp)
 lcTemp2 = loRegExp.UnEscape_Like(m.lcTemp1)
 ?m.lcTemp,m.lcTemp1,m.lcTemp2,m.lcTemp=m.lcTemp2,loRegExp.UnEscape(m.lcTemp1)
ENDPROC &&Test_Escape

PROCEDURE Test_Others		&& Example to use of some other methods
 LOCAL;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 ?loRegExp.GetGroupNames()
 ?loRegExp.GetGroupNumbers()
 ?loRegExp.GroupNameFromNumber(1)
 ?loRegExp.GroupNumberFromName("Name")
ENDPROC &&Test_Others

PROCEDURE Test_IsMatch		&& Example to use IsMatch methods
 LOCAL;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 ?loRegExp.IsMatch("MuhKuh")
 ?loRegExp.IsMatch("MuhKuh")
 ?loRegExp.IsMatch("MuhKuh","ku")
 ?loRegExp.IsMatch("MuhKuh",2)	&&Offset, starts mit 0
ENDPROC &&Test_IsMatch

PROCEDURE Test_Match		&& Example to use Match methods
 LOCAL;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 ?loRegExp.Match("MuhKuh")
 ?loRegExp.Match("MuhKuh")
 ?loRegExp.Match("MuhKuh","ku")
 ?loRegExp.Match("MuhKuh",2)	&&Offset, starts mit 0
 ?loRegExp.Match("MuhKuh",2,1)	&&Offset, starts mit 0
ENDPROC &&Test_Match

PROCEDURE Test_Matches		&& Example to use Matches methods
 LOCAL;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 loRegExp.PATTERN = "\b(\w+\s*)+\."
 ?loRegExp.Matches("MuhKuh")
 ?loRegExp.Matches("MuhKuh","ku")
 ?loRegExp.Matches("MuhKuh",2)	&&Offset, starts mit 0
ENDPROC &&Test_Matches

PROCEDURE Test_Replace		&& Example to use Replace methods
 LOCAL;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 ?loRegExp.REPLACE("This is a sentence. This is another sentence. This is too.","miez")
 ?loRegExp.REPLACE("This is a sentence. This is another sentence. This is too.","miez",2)
 ?loRegExp.REPLACE("This is a sentence. This is another sentence. This is too.","miez",1,2)
 ?loRegExp.REPLACE("This is a sentence. This is another sentence. This is too.","is","miez")
ENDPROC &&Test_Replace

PROCEDURE Test_Split		&& Example to use Split methods
 LOCAL;
  loRegExp AS OBJECT

 loRegExp = Get_SF_RegExp()

 ?loRegExp.SPLIT("MuhKuh")
 ?loRegExp.SPLIT("MuhKuh","uk")
 ?loRegExp.SPLIT("MuhKuh",1)	&&Offset, starts mit 0
 ?loRegExp.SPLIT("MuhKuh",1,1)	&&Offset, starts mit 0
ENDPROC &&Test_Split

PROCEDURE Test_Unwind		&& Example to run Matches for a Pattern and show all data returned
 LOCAL;
  lnCapture  AS NUMBER,;
  lnGroup    AS NUMBER,;
  lnMatch    AS NUMBER,;
  loCapture  AS OBJECT,;
  loCaptures AS OBJECT,;
  loGroup    AS OBJECT,;
  loGroups   AS OBJECT,;
  loMatch    AS OBJECT,;
  loMatches  AS OBJECT,;
  loRegExp   AS OBJECT

 loRegExp = Get_SF_RegExp()

 loRegExp.PATTERN            = "\b(\w+\s*)+\."
 loRegExp.ReturnFoxObjects   = .F.
 loRegExp.AutoExpandGroup    = .F.
 loRegExp.AutoExpandCaptures = .F.
 loMatches                   = loRegExp.Matches("This is a sentence. This is another sentence. This is too.")

 ?"Matches: ", m.loMatches.COUNT
 FOR lnMatch = 0 TO m.loMatches.COUNT-1
  loMatch = loMatches.ITEM(m.lnMatch)
  ?" Match ", m.lnMatch, "Matched text: ", loRegExp.Get_Value(m.loMatch), loRegExp.Get_Index(m.loMatch), loRegExp.Get_Length(m.loMatch), loRegExp.Get_Name(m.loMatch)
  ??", Success ",loRegExp.Get_Success(m.loMatch)

  loCaptures = loRegExp.Get_Captures(m.loMatch)
  ?"  MCaptures: ", m.loCaptures.COUNT
  FOR lnCapture = 0 TO m.loCaptures.COUNT-1
   loCapture = loCaptures.ITEM(m.lnCapture)
   ?"   MCapture ", m.lnCapture, ":", loRegExp.Get_Value(m.loCapture), loRegExp.Get_Index(m.loCapture), loRegExp.Get_Length(m.loCapture)
   ??", Success ",loRegExp.Get_Success(m.loCapture)
   ??", Name ",loRegExp.Get_Name(m.loCapture)
  ENDFOR &&lnCapture

  loGroups = loRegExp.Get_Groups(m.loMatch)
  ?"  Groups: ", m.loGroups.COUNT
  FOR lnGroup = 0 TO m.loGroups.COUNT-1
   loGroup = loGroups.ITEM(m.lnGroup)
   ?"   Group ", m.lnGroup, ":", loRegExp.Get_Value(m.loGroup), loRegExp.Get_Index(m.loGroup), loRegExp.Get_Length(m.loGroup), loRegExp.Get_Success(m.loGroup), loRegExp.Get_Name(m.loGroup)
   ??", Success ",loRegExp.Get_Success(m.loGroup)
   ??", Name ",loRegExp.Get_Name(m.loGroup)
   loCaptures = loRegExp.Get_Captures(m.loGroup)
   ?"    Captures: ", m.loCaptures.COUNT
   FOR lnCapture = 0 TO m.loCaptures.COUNT-1
    loCapture = loCaptures.ITEM(m.lnCapture)
    ?"     Capture ", m.lnCapture, ":", loRegExp.Get_Value(m.loCapture), loRegExp.Get_Index(m.loCapture), loRegExp.Get_Length(m.loCapture)
    IF m.lnGroup =0 THEN
     ??", Success ",loRegExp.Get_Success(m.loCapture)
     ??", Name ",loRegExp.Get_Name(m.loCapture)
    ENDIF &&m.lnGroup =0
   ENDFOR &&lnCapture
  ENDFOR &&lnGroup
 ENDFOR &&lnMatch
ENDPROC &&Test_Unwind

PROCEDURE Get_SF_RegExp	&& Example to instantiate the SF_RegExp class
 LOCAL;
  lcOldPath AS STRING,;
  lcPath    AS STRING,;
  loRegExp  AS OBJECT

 lcPath    = SYS(16)
 lcPath    = RIGHT(m.lcPath,LEN(m.lcPath)-AT(" ",m.lcPath,2))
 lcPath    = JUSTPATH(m.lcPath)
 lcOldPath = FULLPATH("","")

 CD (m.lcPath)

 loRegExp = SF_RegExp()

 CD (m.lcOldPath)
 RETURN m.loRegExp
ENDPROC &&Get_SF_RegExp
