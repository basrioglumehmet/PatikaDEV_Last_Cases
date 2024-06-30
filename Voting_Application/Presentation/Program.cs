using Voting_Application.Application.Services;
using Voting_Application.Application.Services.Impl;
using Voting_Application.Core.Entities;
using Voting_Application.Core.Interfaces;
using Voting_Application.Core.Utilities;
using Voting_Application.Persistence.Repositories;

class Program
{
    static void Main(string[] args)
    {
        // Set up console properties
        Console.Title = "Lütfen Bekleyiniz...";

        // Initialize services and repositories
        UserRepository userRepository = new UserRepository();
        UserService userService = new UserService(userRepository);
        ICategoryService categoryService = new CategoryService();
        IAuthService authService = new AuthService(userService);

        // Create and add categories
        CreateAndAddCategories(categoryService);

        // Prompt user for input
        ConsoleKeyInfo keyInfo = Console.ReadKey();
        HandleUserInput(keyInfo, authService, categoryService);
    }

    private static void CreateAndAddCategories(ICategoryService categoryService)
    {
        Console.WriteLine("Kategoriler Oluşturuluyor...");

        // Simulate some process
        SimulateProcessing();

        Console.WriteLine("Kategoriler Oluşturuldu...");
        Console.Clear();
        Console.Beep();

        // Create categories
        Category category1 = new Category { Name = "Aksiyon" };
        Category category2 = new Category { Name = "Gerilim" };
        Category category3 = new Category { Name = "Bilim Kurgu" };

        // Add categories to service
        categoryService.CreateCategory(category1);
        categoryService.CreateCategory(category2);
        categoryService.CreateCategory(category3);

        Console.ForegroundColor = ConsoleColor.White;
        categoryService.ListCategoriesSelection();
    }

    private static void SimulateProcessing()
    {
        for (int i = 0; i <= 100; i += 5)
        {
            ConsoleUtilities.DrawProgressCircle(i);
            Thread.Sleep(50); // Simulate some processing time
        }
    }

    private static void HandleUserInput(ConsoleKeyInfo keyInfo, IAuthService authService, ICategoryService categoryService)
    {
        if (keyInfo.KeyChar == '0')
        {
            Console.Clear();
            Console.Beep();
            Console.Title = "Kullanıcı Kayıt / Giriş İşlemleri";
            authService.StartAuthenticationProccesses();

            Console.Clear();
            SimulateProcessing();

            Console.Beep();
            Console.WriteLine(" ");
            Console.Clear();
            Console.Beep();
            Console.ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.Clear();
                Console.Beep();
                categoryService.ListCategoriesSelection();

                Console.WriteLine("Çıkmak için 0 basın veya oylamaya devam etmek için herhangi bir tuşa basın.");
                if (Console.ReadKey().KeyChar == '0') break;
            }
        }
        else
        {
            Console.WriteLine("\n0 tuşuna basılmadı.");
        }
    }
}
