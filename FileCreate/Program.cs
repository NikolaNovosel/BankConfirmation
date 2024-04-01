using BankConfirmation_DTO;
using BankConfirmation_UI_MVC.REST;
using BankConfirmations_BLL;


//Account account = new();
//account.GetXml();

//AccountRest acc = new();

AccountBll accountBll = new();

Account a = new();

a.Id = int.Parse(Console.ReadLine());
a.Number = Console.ReadLine();
a.Balance = decimal.Parse(Console.ReadLine());
a.AccountDateOpen = DateTime.Parse(Console.ReadLine());
a.AccountType = Console.ReadLine();
a.ClientId = int.Parse(Console.ReadLine());

accountBll.Update(a);
Console.ReadLine();






