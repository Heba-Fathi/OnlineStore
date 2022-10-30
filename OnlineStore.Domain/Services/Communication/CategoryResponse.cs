namespace OnlineStore.Domain.Services.Communication
{

    public class CategoryResponse : BaseResponse<Category>
    {
        public CategoryResponse(Category category) : base(category)
        { }

        public CategoryResponse(string message) : base(message)
        { }
    }
}
