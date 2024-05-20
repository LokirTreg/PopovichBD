﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 16.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace CodeGeneration.ServerCodeGenerator.Templates
{
    using System.Linq;
    using CodeGeneration.ServerCodeGenerator.Enums;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    internal partial class ViewUpdateTemplate : ViewUpdateTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("@model ");
            
            #line 4 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityDescription.Name));
            
            #line default
            #line hidden
            this.Write("Model\r\n\r\n@{\r\n\tvar exists = Model != null && Model.Id != 0;\r\n\tViewBag.Title = (exi" +
                    "sts ? \"Редактирование\" : \"Создание\") + \" ");
            
            #line 8 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(EntityDescription.Name));
            
            #line default
            #line hidden
            this.Write("\";\r\n}\r\n\r\n<form asp-action=\"Update\" asp-antiforgery=\"true\" method=\"post\">\r\n\t<div c" +
                    "lass=\"row\">\r\n");
            
            #line 13 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
 
foreach (var propertyDescription in EntityDescription.Properties)
{
	var displayType = propertyDescription.GetDisplayType();
	if (displayType == PropertyDisplayType.Hidden)
	{

            
            #line default
            #line hidden
            this.Write("\t\t<input type=\"hidden\" asp-for=\"");
            
            #line 20 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\"/>\r\n");
            
            #line 21 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		continue;
	}

            
            #line default
            #line hidden
            this.Write("\t\t<div class=\"col-md-4 col-sm-6\">\r\n\t\t\t<div class=\"form-group\">\r\n\t\t\t\t<label asp-fo" +
                    "r=\"");
            
            #line 27 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\"></label>\r\n");
            
            #line 28 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

	switch (displayType)
	{
		case PropertyDisplayType.Bool:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<input type=\"checkbox\" asp-for=\"");
            
            #line 33 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" class=\"form-control\"/>\r\n");
            
            #line 34 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
		case PropertyDisplayType.NullableBool:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<select asp-for=\"");
            
            #line 38 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" asp-items=\"@Html.GetNullableBoolSelectList(\"---НЕ ВЫБРАНО---\")\" class=\"form-con" +
                    "trol\"></select>\r\n");
            
            #line 39 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
		case PropertyDisplayType.Enum:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<select asp-for=\"");
            
            #line 43 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" asp-items=\"@(Html.GetEnumSelectList<");
            
            #line 43 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityType.Name));
            
            #line default
            #line hidden
            this.Write(">())\" class=\"form-control\"></select>\r\n");
            
            #line 44 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
		case PropertyDisplayType.NullableEnum:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<select asp-for=\"");
            
            #line 48 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" asp-items=\"@(Html.GetNullableEnumSelectList<");
            
            #line 48 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Nullable.GetUnderlyingType(propertyDescription.EntityType).Name));
            
            #line default
            #line hidden
            this.Write(">(\"---НЕ ВЫБРАНО---\"))\" class=\"form-control\"></select>\r\n");
            
            #line 49 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
		case PropertyDisplayType.BitMask:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<select asp-for=\"");
            
            #line 53 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" asp-items=\"@(Html.GetEnumSelectList<");
            
            #line 53 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityType.GetGenericArguments().First().Name));
            
            #line default
            #line hidden
            this.Write(">(null))\" class=\"form-control\"></select>\r\n");
            
            #line 54 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
		case PropertyDisplayType.Date:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<input type=\"text\" asp-for=\"");
            
            #line 58 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" class=\"form-control dateTimePicker\"/>\r\n");
            
            #line 59 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
		default:

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<input type=\"text\" asp-for=\"");
            
            #line 63 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" class=\"form-control\"/>\r\n");
            
            #line 64 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

		break;
	}

            
            #line default
            #line hidden
            this.Write("\t\t\t\t<span asp-validation-for=\"");
            
            #line 68 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(propertyDescription.EntityName));
            
            #line default
            #line hidden
            this.Write("\" class=\"text-danger\"></span>\r\n\t\t\t</div>\r\n\t\t</div>\r\n");
            
            #line 71 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

}

            
            #line default
            #line hidden
            this.Write(@"	</div>
	<div class=""row"">
		<div class=""col-md-12 text-center"">
			<button class=""btn btn-outline-primary"" type=""submit"">@(exists ? ""Сохранить"" : ""Добавить"")</button>
			<a asp-action=""Index"" class=""btn btn-outline-secondary"">Отмена</a>
		</div>
	</div>
</form>
");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 82 "E:\reps\Dev.Template.AspNetCore\CodeGeneration\ServerCodeGenerator\Templates\ViewUpdateTemplate.tt"

	internal EntityDescription EntityDescription;
	internal int MaxLineWidth;
	internal ViewUpdateTemplate(EntityDescription entityDescription, int maxLineWidth) {
		EntityDescription = entityDescription;
		MaxLineWidth = maxLineWidth;
	}

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    internal class ViewUpdateTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
