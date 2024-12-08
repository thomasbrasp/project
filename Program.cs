namespace Project_Programmeren_Braspenning_Thomas;

internal static class Program
{
   #region Variables

   static readonly (string Name, int Quantity, double Price, string Size, string Description)[] Products =
   [
      ("Cuban Tobacco", 0, 11.11, "30cl", "Cuban Tobacco is celebrated as one of the most distinguished luxury products globally. Its leaves are grown in the fertile, sun-soaked soils of Cuba, where the perfect combination of climate and tradition creates a unique, unmatched quality. Harvested by skilled hands using methods passed down through generations, each tobacco leaf undergoes a meticulous curing process to bring out its full flavor potential. This dedication ensures a product that is not only rich in taste but also deeply steeped in cultural heritage.\n\nThe aroma of Cuban tobacco is an experience in itself—a complex blend of earthy, nutty, and slightly sweet notes that captivate the senses. Whether enjoyed as a cigar or utilized in other forms, its fragrance embodies sophistication and relaxation. This unmatched scent has made it a favorite among connoisseurs who value authenticity and craftsmanship. Every puff carries a story, a journey through time and tradition that connects the smoker with the heart of Cuban culture.\n\nBeyond its sensory appeal, Cuban tobacco is a symbol of excellence and exclusivity. From the lush fields of Vuelta Abajo to the rolling tables of Havana, each step of its creation reflects a commitment to perfection. The result is a product that is not merely smoked but savored, admired, and remembered. Whether you're a seasoned enthusiast or a curious beginner, Cuban tobacco offers a unique opportunity to indulge in a time-honored luxury that has captivated generations."),
      ("Sandalwood", 22, 22.22, "30cl", "Sandalwood has long been cherished for its warm, woody aroma and calming properties. Extracted from the heartwood of the sandalwood tree, its scent is a timeless symbol of serenity and sophistication. Known for its grounding qualities, sandalwood has been used in everything from incense to luxury perfumes, making it a versatile and treasured ingredient. Its rich history spans centuries, carrying with it the essence of ancient traditions and rituals.\n\nThe combination of sandalwood and black pepper creates a truly captivating and harmonious blend. The creamy, soothing notes of sandalwood are perfectly balanced by the subtle, spicy kick of black pepper, resulting in a fragrance that is both dynamic and inviting. This unique pairing evokes a sense of warmth and comfort, making it an ideal choice for those seeking a scent that is both bold and elegant. Whether enjoyed in a candle, diffuser, or personal care product, this blend leaves a lasting impression.\n\nBeyond its luxurious fragrance, sandalwood is renowned for its therapeutic benefits. Its calming aroma helps reduce stress and promote relaxation, while its grounding properties foster a sense of balance and mindfulness. Perfect for unwinding after a long day or setting the mood for a moment of tranquility, sandalwood and black pepper offer an unparalleled sensory experience that transforms any space into a sanctuary of peace and sophistication."),
      ("Lemongrass", 33, 33.33, "40cl", "Lemongrass is celebrated for its fresh, citrusy aroma and energizing properties. Derived from the tall, aromatic grass native to tropical regions, its scent is both uplifting and rejuvenating. Lemongrass has been a staple in culinary, medicinal, and aromatic applications for centuries, offering a versatile and refreshing experience. Its crisp and vibrant fragrance instantly revitalizes the senses, making it a popular choice for those seeking a burst of natural energy.\n\nThe pairing of lemongrass and ginger creates a truly invigorating blend that awakens the mind and body. The zesty brightness of lemongrass harmonizes beautifully with the warm, spicy undertones of ginger, resulting in a scent that is both lively and comforting. This dynamic combination is perfect for creating an environment that feels fresh and energized, making it a favorite for use in candles, diffusers, and personal care products.\n\nBeyond its delightful fragrance, lemongrass offers a range of benefits that go beyond the surface. Known for its purifying properties, it helps cleanse the air and create a refreshing atmosphere. When combined with ginger, the blend not only stimulates the senses but also promotes a sense of well-being and vitality. Whether you're starting your day or seeking a mid-afternoon boost, lemongrass and ginger provide a natural and invigorating experience that leaves a lasting impression."),
      ("Clean Cotton", 44, 44.44, "30cl", "Clean Cotton captures the essence of freshness and simplicity with its crisp and invigorating scent. Evoking the feeling of freshly laundered linens drying in a gentle breeze, this fragrance brings a sense of purity and cleanliness to any space. Its light and airy profile is perfect for those who appreciate a subtle yet uplifting aroma that refreshes the senses and creates a tranquil atmosphere.\n\nThe fragrance of Clean Cotton is both versatile and comforting, making it an excellent choice for enhancing any room. Its delicate notes blend seamlessly with hints of soft florals and a touch of ozone, creating a well-rounded scent that feels timeless and serene. Whether used in a candle, diffuser, or room spray, it brings a welcoming and calming vibe to your home.\n\nMore than just a fragrance, Clean Cotton symbolizes the soothing simplicity of everyday moments. It helps create a peaceful environment where you can relax, unwind, and enjoy the little things. Ideal for refreshing your space after a busy day or setting a cozy ambiance, Clean Cotton is a timeless scent that embodies clarity, comfort, and balance."),
      ("Lavender", 55, 55.55, "50cl", "Lavender is a timeless fragrance that evokes the serene beauty of the sun-drenched fields of Provence. Its soft, floral aroma is synonymous with relaxation and tranquility, offering a sense of calm to the mind and body. For centuries, lavender has been cherished for its versatile properties, from promoting restful sleep to soothing the senses, making it a beloved choice in aromatherapy and perfumery.\n\nThe fragrance of lavender is both delicate and powerful, filling any space with its calming presence. Its floral notes are perfectly balanced with subtle herbal undertones, creating a scent that is both fresh and comforting. Whether used in a candle, diffuser, or essential oil, lavender brings a touch of natural elegance and serenity to your surroundings, making it perfect for unwinding after a long day.\n\nBeyond its aromatic appeal, lavender is a symbol of wellness and self-care. Its soothing properties help ease stress, improve focus, and create a harmonious environment. Ideal for moments of relaxation, meditation, or simply enjoying a peaceful evening, lavender provides an unmatched sensory experience that uplifts the spirit and restores balance."),
      ("Vanilla Bean", 66, 66.66, "35cl", "Vanilla Bean is a classic fragrance that exudes warmth and comfort with its smooth, creamy scent. Its rich aroma, with subtle hints of sweetness, creates an inviting and soothing atmosphere. Revered for its timeless appeal, vanilla bean has long been a favorite in both culinary and aromatic worlds, symbolizing indulgence and relaxation.\n\nThe scent of vanilla bean is a harmonious blend of soft, velvety notes with a gentle sweetness that feels both luxurious and familiar. Its comforting fragrance is perfect for adding a cozy and welcoming touch to any space, whether used in candles, diffusers, or other scented products. Vanilla bean's aroma wraps you in a blanket of warmth, making it ideal for unwinding and enjoying moments of peace.\n\nMore than just a fragrance, vanilla bean has the power to evoke cherished memories and create a sense of calm. Its ability to soothe the senses and uplift the mood makes it a versatile choice for any setting. Whether you're looking to enhance your home with a comforting scent or indulge in a moment of relaxation, vanilla bean offers a delightful and enduring experience that never goes out of style."),
      ("Ocean Breeze", 77, 77.77, "40cl", "Ocean Breeze captures the essence of the sea with its fresh and invigorating aroma, bringing the tranquility of ocean waves into your space. This crisp and breezy fragrance evokes the feeling of a sunny summer day by the coast, with hints of salty air and aquatic notes. Perfect for those who love the ocean's calming presence, it provides a refreshing escape from the everyday.\n\nThe scent of Ocean Breeze is a harmonious blend of clean, airy notes complemented by subtle hints of citrus and floral undertones. Its light yet revitalizing fragrance makes it ideal for creating a serene and uplifting ambiance in any room. Whether used in a candle, diffuser, or room spray, it transports you to a coastal retreat with every breath.\n\nBeyond its refreshing aroma, Ocean Breeze inspires relaxation and a sense of renewal. It helps clear the mind and invigorate the senses, making it an excellent choice for moments of reflection or re-energizing your day. Perfect for bringing the essence of summer into your home year-round, Ocean Breeze is a timeless and rejuvenating fragrance that connects you to the beauty and serenity of the sea."),
      ("Cedar wood", 88, 88.88, "45cl", "Cedar Wood is a rich and grounding fragrance that brings a touch of rustic elegance to any space. With its earthy and warm notes, it evokes the essence of a tranquil forest, making it the perfect choice for moments of relaxation and reflection. Loved for its timeless appeal, cedar wood has long been associated with strength, stability, and natural beauty.\n\nThe scent of cedar wood is a harmonious blend of deep, woody tones with subtle hints of resin and spice. Its bold yet soothing aroma creates a comforting atmosphere, ideal for enhancing your home’s ambiance. Whether used in candles, diffusers, or other scented products, cedar wood adds an inviting and sophisticated touch, making it a favorite for unwinding after a busy day.\n\nMore than just a fragrance, cedar wood is known for its calming and grounding properties. It helps to reduce stress, clear the mind, and foster a sense of balance and peace. Perfect for creating a cozy retreat or complementing a moment of meditation, cedar wood offers a natural and refined sensory experience that connects you to the beauty of the outdoors."),
      ("Eucalyptus Mint", 99, 99.99, "30cl", "Eucalyptus Mint is a revitalizing fragrance that perfectly blends the crispness of mint with the soothing essence of eucalyptus. Its invigorating aroma instantly uplifts the senses, offering a refreshing escape that clears the mind and revitalizes the body. This dynamic combination is cherished for its ability to create a balanced atmosphere, simultaneously energizing and calming.\n\nThe scent of Eucalyptus Mint features the cool, bright notes of mint harmonizing with the fresh, herbaceous aroma of eucalyptus. Together, they create a fragrance that is both crisp and therapeutic, ideal for enhancing any space with a sense of clarity and serenity. Whether used in candles, diffusers, or sprays, Eucalyptus Mint delivers a breath of fresh air, making it perfect for moments of relaxation or focus.\n\nBeyond its delightful fragrance, Eucalyptus Mint is renowned for its wellness benefits. The refreshing qualities of mint awaken the senses, while eucalyptus offers calming and purifying properties that promote relaxation and well-being. Ideal for refreshing your environment or unwinding after a long day, Eucalyptus Mint provides a revitalizing and soothing sensory experience that leaves you feeling recharged and at peace.")
//      "Pine Forest", 0, 100.00, "40cl", "Pine Forest captures the essence of nature with its deep, woodsy fragrance that transports you to a serene evergreen grove. Its rich, earthy aroma is perfect for creating a cozy and refreshing winter ambiance, evoking memories of crisp forest air and snowy landscapes. This timeless scent is a favorite for those who appreciate the natural beauty of the great outdoors.\n\nThe fragrance of Pine Forest combines the bold and invigorating notes of pine needles with subtle hints of resin and moss. Its fresh, grounding aroma fills any space with a sense of tranquility and warmth, making it ideal for enhancing your home during the colder months. Whether used in candles, diffusers, or room sprays, Pine Forest creates a welcoming and festive atmosphere that is perfect for the holiday season.\n\nBeyond its seasonal charm, Pine Forest is known for its rejuvenating and clarifying properties. Its crisp and refreshing scent helps to purify the air and promote a sense of calm and focus. Ideal for relaxing evenings or setting a cheerful holiday mood, Pine Forest offers a natural and uplifting sensory experience that connects you to the peace and beauty of a winter forest."
   ];
   static readonly string[] Reviews =
   [
      "\"Amazing scents and beautifully crafted candles—highly recommend!\"  - Jhon Doe",
      "\"The perfect gift idea, I’ll definitely be ordering again!\"  - Sarah Williams",
      "\"Great quality and fast delivery, exceeded my expectations.\"  - Emily Johnson",
      "\"Love the variety of scents, my home has never smelled better!\"  - Michael Brown",
      "\"Elegant designs, long-lasting fragrance—absolutely worth it.\"  - Olivia Smith",
      "\"Top-notch customer service and incredible candles!\"  - David Martin",
      "\"A cozy atmosphere in a candle, could’t be happier.\"  - Emma Davis",
      "\"Superb craftsmanship, the candles burn evenly and smell divine.\"  - James Wilson",
      "\"Affordable luxury—these candles brighten any room!\"  - Sophia Miller",
      "\"The best handmade candles I’ve tried, you won’t regret it!\"  - William Garcia"
   ];
   static (int rows, string logoString)[] _logoArchive =
   [
      (5, @"██   ██ ███████ ██ ██████  ███████ ███████ ███    ████  ██  ██      ██ ██   ██ ██      ██      ████   ███████   █████   ██ ██████  ███████ █████   ██ ██  ████  ██  ██      ██ ██   ██      ██ ██      ██  ██ ████   ██ ███████ ██ ██   ██ ███████ ███████ ██   ████"),
      (4, @"_     _ _______ _____  ______ _______ _______ __   _|____/  |______   |   |_____/ |______ |______ | \  ||    \_ |______ __|__ |    \_ ______| |______ |  \_|                                                    ")
   ];
   static string[,] _logoArrayKeirsen =
   {
      { "8", "8", "8", " ", " ", " ", " ", "d", "8", "P", " ", " ", "8", "8", "8", "8", "8", "8", "8", "8", "8", "8", " ", "8", "8", "8", "8", "8", "8", "8", " ", "8", "8", "8", "8", "8", "8", "8", "b", ".", " ", " ", " ", ".", "d", "8", "8", "8", "8", "b", ".", " ", " ", "8", "8", "8", "8", "8", "8", "8", "8", "8", "8", " ", "8", "8", "8", "b", " ", " ", " ", " ", "8", "8", "8" },
      { "8", "8", "8", " ", " ", " ", "d", "8", "P", " ", " ", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "8", "8", "8", " ", " ", " ", "Y", "8", "8", "b", " ", "d", "8", "8", "P", " ", " ", "Y", "8", "8", "b", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", "8", "b", " ", " ", " ", "8", "8", "8" },
      { "8", "8", "8", " ", " ", "d", "8", "P", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "8", "8", "8", " ", " ", " ", " ", "8", "8", "8", " ", "Y", "8", "8", "b", ".", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", "8", "8", "b", " ", " ", "8", "8", "8" },
      { "8", "8", "8", "d", "8", "8", "K", " ", " ", " ", " ", " ", "8", "8", "8", "8", "8", "8", "8", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "8", "8", "8", " ", " ", " ", "d", "8", "8", "P", " ", " ", " ", "Y", "8", "8", "8", "b", ".", " ", " ", " ", "8", "8", "8", "8", "8", "8", "8", " ", " ", " ", " ", "8", "8", "8", "Y", "8", "8", "b", " ", "8", "8", "8" },
      { "8", "8", "8", "8", "8", "8", "8", "b", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "8", "8", "8", "8", "8", "8", "8", "P", " ", " ", " ", " ", " ", " ", " ", " ", "Y", "8", "8", "b", ".", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", "Y", "8", "8", "b", "8", "8", "8" },
      { "8", "8", "8", " ", " ", "Y", "8", "8", "b", " ", " ", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "8", "8", "8", " ", "T", "8", "8", "b", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", "Y", "8", "8", "8", "8", "8" },
      { "8", "8", "8", " ", " ", " ", "Y", "8", "8", "b", " ", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "8", "8", "8", " ", " ", "T", "8", "8", "b", " ", " ", "Y", "8", "8", "b", " ", " ", "d", "8", "8", "P", " ", "8", "8", "8", " ", " ", " ", " ", " ", " ", " ", " ", "8", "8", "8", " ", " ", " ", "Y", "8", "8", "8", "8" },
      { "8", "8", "8", " ", " ", " ", " ", "Y", "8", "8", "b", " ", "8", "8", "8", "8", "8", "8", "8", "8", "8", "8", " ", "8", "8", "8", "8", "8", "8", "8", " ", "8", "8", "8", " ", " ", " ", "T", "8", "8", "b", " ", " ", " ", "Y", "8", "8", "8", "8", "P", " ", " ", " ", "8", "8", "8", "8", "8", "8", "8", "8", "8", "8", " ", "8", "8", "8", " ", " ", " ", " ", "Y", "8", "8", "8" }
   };

   const string StoreName = "Keirsen";
   const  string  AdminPassword = "admin123";
   static string? _userName;
   static bool    _adminLogin;

   //spacings for layout
   const  int SpacingIndex             = 5;
   const  int SpacingColumnGap         = 5;
   static int _spacingMaxNameLength     = -1 * MaxLengthProductNames(); //Length + 3, inverted to align left
   const  int SpacingQuantity          = 8; //increased spacing to prevent "sold out" items from breaking the intended layout
   const  int SpacingQuantityForHeader = -(SpacingQuantity + SpacingColumnGap); //inverting to align left

   static string[] _stockPreviewHeaderValues  = ["", "Name", "Stock", "", "Name", "Stock\n"];
   static int[]    _stockPreviewHeaderSpacing = [SpacingIndex, _spacingMaxNameLength, SpacingQuantityForHeader, SpacingColumnGap, _spacingMaxNameLength, _stockPreviewHeaderValues[^1].Length]; //[^1] equals last index

#endregion

   static void Main(string[] args)
   {
      WelcomeScreen(); //LogoFromString > Get username > C.Clear > LogoFromString > Welcome message
      ContinueOnKey();

      bool leaveProgram = false;
      while (!leaveProgram) //main menu loop
      {
         StockPreview();
         MainMenu(); //expected input from user 1-5, default will handle divergent answers
         ConsoleKeyInfo menuChoice = Console.ReadKey(true);
         int userChoice;
         switch (menuChoice.Key)
         {
            default:
               Console.WriteLine("Invalid input.");
               break;
            case ConsoleKey.NumPad1: //productinfo
            case ConsoleKey.D1:
               StockPreview();
               userChoice = AskUseForAmountOfAction("view");
               ShowProductInfo(userChoice);
               break;
            case ConsoleKey.NumPad2: //product purchase
            case ConsoleKey.D2:

               StockPreview();
               bool quit = false;
               userChoice = AskUseForAmountOfAction("buy");
               if (Products[userChoice].Quantity == 0)
               {
                  Console.Write("The product you chose is currently sold out.");
                  ContinueOnKey();
               }
               else
               {
                  int buyQuantity;
                  do
                  {
                     buyQuantity = AskUserForTheAmountToBuy(userChoice);
                     if (buyQuantity > 0 && buyQuantity <= Products[userChoice].Quantity)
                     {
                        Products[userChoice].Quantity -= buyQuantity;
                        DisplayPurchaseDetails(userChoice, buyQuantity);
                     }
                     else
                     {
                        buyQuantity = -1;
                        userChoice = AskUseForAmountOfAction("buy");
                     }
                  } while (buyQuantity < 0 && quit == false);
               }


               break;
            case ConsoleKey.NumPad3: //admin login
            case ConsoleKey.D3:
               Console.Clear();
               bool goBack = false;
               if (_adminLogin) //if adminlogin is true > logout
               {
                  _adminLogin = false;
                  Console.WriteLine("You successfully logged out as admin");
                  ContinueOnKey();
               }
               else //login
               {
                  Console.WriteLine("Please enter the admin password: --> admin123");
                  while (!_adminLogin && !goBack) //loop until logged in || exit by choice
                  {
                     string loginAttempt = PasswordReader(); //magic

                     if (loginAttempt == "exit") //escape route
                     {
                        goBack = true;
                        Console.WriteLine();
                        ContinueOnKey();
                     }
                     else if (AdminPassword == loginAttempt)
                     {
                        WriteGreen("\nyou successfully logged in as admin.\n");
                        ContinueOnKey();
                        _adminLogin = true;
                     }
                     else
                     {
                        Console.WriteLine("\nIncorrect password, please try again or enter 'exit' to leave");
                     }
                  }
               }

               break;
            case ConsoleKey.NumPad4: //exit application
            case ConsoleKey.D4:
               Console.Write("Are you sure you want to exit the store? Press 'Y' if you are sure, any other key will bring you back to the main menu.");
               ConsoleKeyInfo key = Console.ReadKey(true);
               if (key.Key == ConsoleKey.Y)
               {
                  Console.Clear();
                  ClosingCredits();
                  Console.ReadLine();

                  leaveProgram = true;
               }
               break;
            case ConsoleKey.NumPad5: //refill products
            case ConsoleKey.D5:
               if (_adminLogin)
               {
                  StockPreview();
                  Thread.Sleep(250);
                  userChoice = AskUseForAmountOfAction("refill");
                  int refillQuantity = AskUserForTheAmountToRefill(userChoice);
                  string pluralRefillQuantityOrNot = refillQuantity == 1? "time" : "times";
                  WriteStripedLine();
                  Console.Write($"You successfully refilled {Products[userChoice].Name} {refillQuantity} {pluralRefillQuantityOrNot}.\n");
                  Products[userChoice].Quantity += refillQuantity;
                  Console.Write($"Currently there are {Products[userChoice].Quantity} of {Products[userChoice].Name}\n");
                  ContinueOnKey();
               }
               break;

         }

      }
   }

   #region Logo And Overloads
   static void DisplayLogo()
   {
      string[,] logo =
      {
         { "#", " ", " ", "#", " ", "#", "#", "#", "#", " ", "#", "#", "#", " ", "#", "#", "#", " ", " ", " ", "#", "#", " ", " ", "#", "#", "#", "#", " ", "##", " ", " ", " ", "#" },
         { "#", " ", "#", " ", " ", "#", " ", " ", " ", " ", " ", "#", " ", " ", "#", " ", " ", "#", " ", "#", " ", " ", "#", " ", "#", " ", " ", " ", " ", "#", "#", " ", "  ", "#" },
         { "#", "#", " ", " ", " ", "#", " ", " ", " ", " ", " ", "#", " ", " ", "#", " ", " ", "#", " ", "#", " ", " ", " ", " ", "#", " ", " ", " ", " ", "#", "", "#", "   ", "#" },
         { "#", " ", " ", " ", " ", "#", "#", "#", " ", " ", " ", "#", " ", " ", "#", " ", "#", " ", " ", " ", "#", "#", " ", " ", "#", "#", "#", " ", " ", "#", " ", "#", "  ", "#" },
         { "#", " ", " ", " ", " ", "#", " ", " ", " ", " ", " ", "#", " ", " ", "#", "#", " ", " ", " ", " ", " ", " ", "#", " ", "#", " ", " ", " ", " ", "#", " ", "", "#", "  #" },
         { "#", "#", " ", " ", " ", "#", " ", " ", " ", " ", " ", "#", " ", " ", "#", " ", "#", " ", " ", " ", " ", " ", "#", " ", "#", " ", " ", " ", " ", "#", " ", " ", "#", " #" },
         { "#", " ", "#", " ", " ", "#", " ", " ", " ", " ", " ", "#", " ", " ", "#", " ", "", "#", "  ", "#", " ", " ", "#", " ", "#", " ", " ", " ", " ", "#", " ", "  ", "#", "#" },
         { "#", " ", " ", "#", " ", "#", "#", "#", "#", " ", "#", "#", "#", " ", "#", " ", " ", "#", " ", " ", "#", "#", " ", " ", "#", "#", "#", "#", " ", "#", " ", " ", " ", "##" }
      };

      // Display the 2D array
      for (int i = 0; i < logo.GetLength(0); i++)
      {
         for (int j = 0; j < logo.GetLength(1); j++)
         {
            Console.Write(logo[i, j] + " ");
         }
         Console.WriteLine();
      }
   } //display standard LogoArchive
   static void DisplayLogo(string[,] logo)
   {
      // Display the 2D array
      for (int i = 0; i < logo.GetLength(0); i++)
      {

         for (int j = 0; j < logo.GetLength(1); j++)
         {
            Console.Write(logo[i, j]);
         }
         Console.WriteLine();
      }
   } //replace default 2d array
   static void DisplayLogo(int index) //replace LogoArchive with string
   {
      int rows = _logoArchive[index].rows;
      string logoString = _logoArchive[index].logoString;

      int columns = ColumnCountLogo(logoString.Length, rows); //get column length, 0 if not divisible
      if (columns != 0)
      {
         string[,] logo = new string[rows, columns];
         LogoStringToMultiDimensional(logoString, logo);
         for (int i = 0; i < logo.GetLength(0); i++)
         {

            for (int j = 0; j < logo.GetLength(1); j++)
            {
               Console.Write(logo[i, j]);
            }
            Console.WriteLine();
         }
      }
      else
      {
         Console.Write("Sorry mate you're doing it wrong.");
      }
   } //if LogoArchive is not default

   static int ColumnCountLogo(int stringLength, int number) => stringLength % number == 0? stringLength / number : 0; //length % rows = 0 ? --> calc column length : if not return 0
   static void LogoStringToMultiDimensional(string logoString, string[,] logo)
   {
      int index = 0; //counter outside scope of loops
      for (int i = 0; i < logo.GetLength(0); i++)
      {
         for (int j = 0; j < logo.GetLength(1); j++)
         {
            logo[i, j] = logoString[index].ToString();
            index++;
         }
      }
   } //fill array with logoString

#endregion

   #region Menu and Display Methods

   static void WelcomeScreen()
   {
      Console.ForegroundColor = ConsoleColor.Magenta;
      DisplayLogo(0);
      Console.Write("\nEnter your name: ");

      Console.BackgroundColor = ConsoleColor.Gray;
      GetUsername();
      Console.ResetColor();
      Console.Clear();

      Console.ForegroundColor = ConsoleColor.Magenta;
      DisplayLogo(_logoArrayKeirsen);
      Console.WriteLine($"\nWelcome {_userName}!");
      Console.WriteLine($"Here at {StoreName}, our candles are lovingly crafted from 100% natural ingredients.\nEnjoy browsing our collection and find the perfect candle to enhance your living space!");
      Console.ResetColor();
   } //LogoFromString > Get username > C.Clear > LogoFromString > Welcome message
   static void ClosingCredits()
   {
      DisplayLogo();
      WriteStripedLine();
      Console.WriteLine(
                        "Ge zijt een keirs!\n" +
                        "The magic of \"Ge zijt een keirs!\" is all in the layers of meaning that come together naturally in the dialect.\n" +
                        "It’s one of those moments where language, culture, and context just align perfectly. By all means hope to see you again!");
      Console.WriteLine($"Goodbye");
      ContinueOnKey();
   }
   static void MainMenu()
   {
      Console.WriteLine("What would you like to do?\n");
      Console.WriteLine("\t\t1. Learn more about a product");
      Console.WriteLine("\t\t2. Purchase a product");

      if (!_adminLogin) WriteRed("\t\t3. Admin Login\n");
      else WriteGreen("\t\t3. Admin is logged in (press '3' again to log out as admin)\n");

      Console.WriteLine("\t\t4. Leave store");
      if (_adminLogin) Console.WriteLine("\t\t5. Refill a product");
   } //display's main menu and changes option choice depending on a successful admin login.

   static string DisplayFormatLayout(string[] values, int[] spacings)
   {
      string formatString = "";
      for (int i = 0; i < values.Length; i++) formatString += $"{{{i},{spacings[i]}}}"; //every iteration you create an index combined with the associated spacing. Mimic of the format:
      //formatString = $"{0, spacing[0]}{1, spacing[1]}{2, spacing[2]}{2, spacing[2]}     //on return the indexes of the format will be filled with the array with values

      return string.Format(formatString, [..values]); //Formats a layout string based on the specified values and spacings.
   }
   static void StockPreview()
   {
      Console.Clear();
      Console.Write(DisplayFormatLayout(_stockPreviewHeaderValues, _stockPreviewHeaderSpacing)); //Header for stock preview
      WriteStripedLine();

      int halfIndex = (Products.Length + 1) / 2; //forcing the left column to be dominant
      for (int i = 0; i < halfIndex; i++)
      {
         RowFormatStockPreview(i); //first column
         Console.Write(new string(' ', SpacingColumnGap)); //creates gap between first column and second

         if (i + halfIndex < Products.Length) RowFormatStockPreview(i + halfIndex); //second column

         Console.WriteLine(); //every iteration writes one line of products
      }
      Review(Reviews);
      WriteStripedLine();
   }
   static void RowFormatStockPreview(int index)
   {
      string[] indexNameValues = [$"{index + 1})  ", Products[index].Name];
      int[] indexNameSpacing = [SpacingIndex, _spacingMaxNameLength];
      Console.Write(DisplayFormatLayout(indexNameValues, indexNameSpacing));
      SoldOutCheck(index);
   }
   static void SoldOutCheck(int index)
   {
      string formatQuantity = $"{{0, -{SpacingQuantity}}}";

      if (Products[index].Quantity == 0) WriteRed(string.Format(formatQuantity, "Sold out"));
      else Console.Write(formatQuantity, Products[index].Quantity);
   } //When quantity = 0, replace text to Sold out
   static void Review(string[] reviewArray)
   {
      Random random = new Random();
      int randomNumber = random.Next(0, reviewArray.Length);
      string output = reviewArray[randomNumber];
      WriteColor(ConsoleColor.DarkBlue, (($"\n{output}\n")));
   }

   static void ShowProductInfo(int index)
   {
      Console.Clear();
      string quantity = $"Currently we have {Products[index].Quantity} available. ";
      string price = $"Priced at {Products[index].Price}eu";
      Console.WriteLine($"{Products[index].Name} is brought to you in a {Products[index].Size} candle.");
      if (Products[index].Quantity == 0)
      {
         quantity = $"{Products[index].Name} has been very popular and is sold out.\n";
         WriteRed(quantity);
      }
      else
      {
         Console.Write(quantity);
         Console.WriteLine(price);
      }
      WriteStripedLine();
      Console.WriteLine($"Extra info:\n\n{Products[index].Description}\n\n");
      ContinueOnKey();
   }
   static void DisplayPurchaseDetails(int index, int amount)
   {
      WriteStripedLine();
      double total = amount * Products[index].Price;
      WriteGreen($"You successfully purchased {amount}x {Products[index].Name}\n");
      Console.Write($"{amount} x {Products[index].Price} = {total:f2}eu ");
      WriteRed($"=> {1.21 * total:F2}eu (with VAT)\n\n");
      ContinueOnKey();
   }
#endregion
   #region User Interaction Methods
   static void GetUsername()
   {
      _userName = Console.ReadLine();
      _userName = string.IsNullOrWhiteSpace(_userName)? "guest" : _userName.Replace(_userName[0], char.ToUpper(_userName[0]));
   }
   static int AskUseForAmountOfAction(string action)
   {
      int amountOfProducts = GetAmountOfProducts();
      Console.Write($"Enter the number (1-{amountOfProducts}) corresponding to the product you'd like to {action}: ");
      while (true)
      {
         string input = Console.ReadLine();
         if (int.TryParse(input, out int index) && 0 < index && index <= amountOfProducts)
         {
            index = IndexAsIntended(index);
            return index;
         }
         Console.Write("Invalid Input. Please enter a valid number: ");
      }
   }
   static int AskUserForTheAmountToBuy(int index)
   {
      int quantity;
      if (Products[index].Quantity == 0)
      {
         Console.Write("This product is sold out");
      }
      else
      {
         WriteStripedLine();
         Console.Write($"Currently we have {Products[index].Quantity} {Products[index].Name}. Priced at {Products[index].Price}eu.\nHow many would you like to buy? ");
      }

      do
      {
         string input = Console.ReadLine();

         if (!int.TryParse(input, out quantity) && quantity <= 0) Console.WriteLine("Invalid input. Please enter a valid number.");
         else if (quantity > Products[index].Quantity) Console.WriteLine("We don't have enough items of your choice, please try again.");
      } while (quantity < 0 && quantity > Products[index].Quantity);

      return quantity;
   }
   static int AskUserForTheAmountToRefill(int index)
   {
      int quantity = 0;
      while (quantity <= 0)
      {
         Console.Write($"How many {Products[index].Name} would you like to refill? ");
         string? input = Console.ReadLine();
         if (!int.TryParse(input, out quantity) && 0 < quantity && quantity <= GetAmountOfProducts()) Console.WriteLine("Invalid Input. Please enter a valid number:");
         else if (quantity <= 0) Console.WriteLine("Please enter a number above 0\n");
      }
      return quantity;
   }
#endregion
   #region Utility

   static int GetAmountOfProducts() => Products.Length; //gets amount of products so the UserItemChoiceInput prompt in the main menu gets adjusted to the amount of products.
   static int MaxLengthProductNames()
   {
      int length = 0;
      for (int index = 0; index < Products.Length; index++)
      {
         (string Name, int Quantity, double Price, string Size, string Description) product = Products[index];
         if (product.Name.Length > length)
            length = product.Name.Length;
      }
      length += 3;
      return length;
   } //checking string length in order to format dynamically (in Stock Preview)
   static int IndexAsIntended(int index)
   {
      if (index > 0) index -= 1;
      return index;
   } //if not null, -1
   static string PasswordReader()
   {
      string password = String.Empty; //not null
      ConsoleKeyInfo key;
      do
      {
         key = Console.ReadKey(true);
         if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
         {
            password += key.KeyChar;
            Console.Write("*");
         } //not backspace & not enter
         else if (key.Key == ConsoleKey.Backspace && password.Length > 0)
         {
            password = password.Substring(0, password.Length - 1);
            Console.Write("\b \b");
         } //if backspace and more then 1 char
      } while (key.Key != ConsoleKey.Enter); //enter = end loop = return password
      return password;
   }
   static void ContinueOnKey() //prompts user to press any key to continue > C.Clear
   {
      Console.WriteLine($"Press any button to continue...");
      Console.ReadLine();
   }
   static void WriteRed(string message)
   {
      Console.ForegroundColor = ConsoleColor.Red;
      Console.Write(message);
      Console.ResetColor();
   }
   static void WriteGreen(string message)
   {
      Console.ForegroundColor = ConsoleColor.Green;
      Console.Write(message);
      Console.ResetColor();
   }
   static void WriteColor(ConsoleColor color, string text)
   {
      Console.ForegroundColor = color;
      Console.Write(text);
      Console.ResetColor();
   }
   static string GetStripedLine() => new('-', int.Abs(SpacingIndex) + int.Abs(SpacingColumnGap) + 2 * int.Abs(_spacingMaxNameLength) + 2 * int.Abs(SpacingQuantityForHeader));
   static void WriteStripedLine() => Console.WriteLine(GetStripedLine());
#endregion
}