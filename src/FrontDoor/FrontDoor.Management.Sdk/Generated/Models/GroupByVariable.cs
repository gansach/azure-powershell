// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.10.4, generator: @autorest/powershell@4.0.737)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using System.Linq;

    /// <summary>
    /// Describes the variables available to group the rate limit requests
    /// </summary>
    public partial class GroupByVariable
    {
        /// <summary>
        /// Initializes a new instance of the GroupByVariable class.
        /// </summary>
        public GroupByVariable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GroupByVariable class.
        /// </summary>

        /// <param name="variableName">Describes the supported variable for group by
        /// Possible values include: &#39;SocketAddr&#39;, &#39;GeoLocation&#39;, &#39;None&#39;</param>
        public GroupByVariable(string variableName)

        {
            this.VariableName = variableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets describes the supported variable for group by Possible values include: &#39;SocketAddr&#39;, &#39;GeoLocation&#39;, &#39;None&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "variableName")]
        public string VariableName {get; set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.VariableName == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "VariableName");
            }

        }
    }
}