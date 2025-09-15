namespace AdminPanel;

public static partial class ESM
{
    public const string CartsPage = "~/esm/Modules/ECommerceWebsite/Carts/CartsPage.js";
    public const string CategoriesPage = "~/esm/Modules/ECommerceWebsite/Categories/CategoriesPage.js";
    public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
    public const string ProductImagesPage = "~/esm/Modules/ECommerceWebsite/ProductImages/ProductImagesPage.js";
    public const string ProductsPage = "~/esm/Modules/ECommerceWebsite/Products/ProductsPage.js";
    public const string ReviewsPage = "~/esm/Modules/ECommerceWebsite/Reviews/ReviewsPage.js";
    public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
    public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
    public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
    public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";

    public static partial class Modules
    {
        public static partial class Administration
        {
            public static partial class Language
            {
                public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
            }

            public static partial class Role
            {
                public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
            }

            public static partial class Translation
            {
                public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
            }

            public static partial class User
            {
                public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";
            }
        }

        public static partial class Common
        {
            public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
        }

        public static partial class ECommerceWebsite
        {
            public static partial class Carts
            {
                public const string CartsPage = "~/esm/Modules/ECommerceWebsite/Carts/CartsPage.js";
            }

            public static partial class Categories
            {
                public const string CategoriesPage = "~/esm/Modules/ECommerceWebsite/Categories/CategoriesPage.js";
            }

            public static partial class ProductImages
            {
                public const string ProductImagesPage = "~/esm/Modules/ECommerceWebsite/ProductImages/ProductImagesPage.js";
            }

            public static partial class Products
            {
                public const string ProductsPage = "~/esm/Modules/ECommerceWebsite/Products/ProductsPage.js";
            }

            public static partial class Reviews
            {
                public const string ReviewsPage = "~/esm/Modules/ECommerceWebsite/Reviews/ReviewsPage.js";
            }
        }

        public static partial class Membership
        {
            public static partial class Account
            {
                public static partial class Login
                {
                    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
                }

                public static partial class SignUp
                {
                    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
                }
            }
        }
    }
}