using Bogus;
using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;

namespace CommonTestUtilities.Requests;

public class RequestRegisterExpenseJsonBuilder
{
    public RequestRegisterExpenseJson Build()
    {
        //var faker = new Faker();

        //var request = new RequestRegisterExpenseJson
        //{
        //    Title = faker.Commerce.Product(),
        //    Description = faker.Commerce.ProductDescription(),
        //    Date = faker.Date.Past(),
        //    Amount = faker.Finance.Amount(1, 1000),
        //    PaymentType = faker.PickRandom<PaymentType>()
        //};

        return new Faker<RequestRegisterExpenseJson>()
            .RuleFor(r => r.Title, f => f.Commerce.Product())
            .RuleFor(r => r.Description, f => f.Commerce.ProductDescription())
            .RuleFor(r => r.Date, f => f.Date.Past())
            .RuleFor(r => r.Amount, f => f.Finance.Amount(1, 1000))
            .RuleFor(r => r.PaymentType, f => f.PickRandom<PaymentType>())
            .Generate();
    }
}