using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public class TestEntity
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestEntity"/> class.
        /// </summary>
        public TestEntity()
        {
        }

        /// <summary>
        /// The entity id
        /// </summary>
        private string entityId;

        /// <summary>
        /// The entity name
        /// </summary>
        private string entityName;

        /// <summary>
        /// Gets or sets entity Id
        /// </summary>
        /// <value>
        /// The entity id.
        /// </value>
        public string EntityId
        {
            get { return this.entityId; }
            set { this.entityId = value; }
        }

        /// <summary>
        /// Gets or sets the entity Name
        /// </summary>
        /// <value>
        /// The name of the entity.
        /// </value>
        public string EntityName
        {
            get { return this.entityName; }
            set { this.entityName = value; }
        }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>The id.</value>
        protected string Id
        {
            get
            {
                return new Guid().ToString();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
