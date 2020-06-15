using GraphQL.Types;
using OnlineGraphQLMicroservice.Entities;

namespace OnlineGraphQLMicroservice.Types
{
    public class ConcreteScmDetailsType : ObjectGraphType<ConcreteScmDetails>
    {
        public ConcreteScmDetailsType()
        {
            Field(x => x.Fly_ash);
            Field(x => x.Slag);
        }
    }
}
