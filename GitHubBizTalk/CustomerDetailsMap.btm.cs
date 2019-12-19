namespace GitHubBizTalk {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GitHubBizTalk.InputSchema", typeof(global::GitHubBizTalk.InputSchema))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GitHubBizTalk.OutputSchema", typeof(global::GitHubBizTalk.OutputSchema))]
    public sealed class CustomerDetailsMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:s0=""http://GitHubBizTalk.InputSchema"" xmlns:ns0=""http://GitHubBizTalk.OutputSchema"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:Root"" />
  </xsl:template>
  <xsl:template match=""/s0:Root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(string(FirstName/text()) , string(MiddleName/text()) , string(LastName/text()))"" />
    <ns0:Root>
      <FullNameCustomer>
        <xsl:value-of select=""$var:v1"" />
      </FullNameCustomer>
    </ns0:Root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0, string param1, string param2)
{
   return param0 + param1 + param2;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GitHubBizTalk.InputSchema";
        
        private const global::GitHubBizTalk.InputSchema _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GitHubBizTalk.OutputSchema";
        
        private const global::GitHubBizTalk.OutputSchema _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"GitHubBizTalk.InputSchema";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GitHubBizTalk.OutputSchema";
                return _TrgSchemas;
            }
        }
    }
}
