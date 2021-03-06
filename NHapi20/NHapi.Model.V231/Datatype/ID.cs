using System;

using NHapi.Base.Model;
namespace NHapi.Model.V231.Datatype
{
/// <summary>/// Summary description for ID.
/// </summary>
public class ID: NHapi.Base.Model.Primitive.ID
{
/// <summary>Return the version
/// <returns>2.3.1</returns>
///</summary>

            virtual public System.String Version
            {
			    get
			    {
				    return "2.3.1";
			    }
		    }
            


                ///<summary>Construct the type
                ///<param name="theMessage">message to which this Type belongs</param>
                ///<param name="theTable">The table which this type belongs</param>
                ///</summary>
                public ID(IMessage theMessage,int theTable):base(theMessage, theTable)
                {}
                


                ///<summary>Construct the type
                ///<param name="message">message to which this Type belongs</param>
                ///<param name="theTable">The table which this type belongs</param>
                ///<param name="description">The description of this type</param>
                ///</summary>
		        public ID(IMessage message, int theTable, string description) : base(message,theTable, description)
    	        {}
                }}