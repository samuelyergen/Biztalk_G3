namespace G3_2022 {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G3_2022.AskRights_Schema", typeof(global::G3_2022.AskRights_Schema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"G3_2022.AnsweredAccess_Schema", typeof(global::G3_2022.AnsweredAccess_Schema))]
    public sealed class AskRight_To_AnsweredAccess : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://G3_2021.AskRights_Schema"" xmlns:ns0=""http://G3_2021.AnsweredAccess_Schema"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AskRights"" />
  </xsl:template>
  <xsl:template match=""/s0:AskRights"">
    <ns0:AnsweredAccess>
      <Access>
        <xsl:text>false</xsl:text>
      </Access>
      <CardID>
        <xsl:value-of select=""CardID/text()"" />
      </CardID>
    </ns0:AnsweredAccess>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"G3_2022.AskRights_Schema";
        
        private const global::G3_2022.AskRights_Schema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"G3_2022.AnsweredAccess_Schema";
        
        private const global::G3_2022.AnsweredAccess_Schema _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"G3_2022.AskRights_Schema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"G3_2022.AnsweredAccess_Schema";
                return _TrgSchemas;
            }
        }
    }
}
