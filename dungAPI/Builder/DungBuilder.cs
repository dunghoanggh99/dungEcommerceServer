namespace dungEcommerceAPI.Builder
{
    public static class DungBuilder
    {
        public static void UseDungBuilder(this IApplicationBuilder buider, bool isDevelopment)
        {
            // Configure the HTTP request pipeline.
            if (isDevelopment)
            {
                buider.UseSwagger();
                buider.UseSwaggerUI();
            }

            buider.UseHttpsRedirection();

            buider.UseAuthorization();
        }
    }
}
