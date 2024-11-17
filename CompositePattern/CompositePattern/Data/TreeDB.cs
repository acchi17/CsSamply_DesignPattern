namespace CompositePattern.Data
{
    internal static class TreeDB
    {
        internal static IEnumerable<TreeEntity> GetTree()
        {
            var result = new List<TreeEntity>();

            result.Add(new TreeEntity(1, 0, 1, "Common"));
            result.Add(new TreeEntity(10, 1, 1, "Recipe"));
            result.Add(new TreeEntity(101, 10, 1, "AutoProcRecipe"));
            result.Add(new TreeEntity(102, 10, 1, "AutoPickupRecipe"));
            result.Add(new TreeEntity(1011, 101, 2, "athwart.tool"));
            result.Add(new TreeEntity(1012, 101, 2, "shape.tool"));
            result.Add(new TreeEntity(1013, 101, 2, "skitter.tool"));
            result.Add(new TreeEntity(1021, 102, 2, "recess.tool"));
            result.Add(new TreeEntity(1022, 102, 2, "recharge.tool"));

            result.Add(new TreeEntity(2, 0, 1, "Staff"));
            result.Add(new TreeEntity(20, 2, 1, "Recipe"));
            result.Add(new TreeEntity(201, 20, 1, "AutoProcRecipe"));
            result.Add(new TreeEntity(202, 20, 1, "AutoPickupRecipe"));
            result.Add(new TreeEntity(2011, 201, 2, "athwart.tool"));
            result.Add(new TreeEntity(2012, 201, 2, "omega.tool"));
            result.Add(new TreeEntity(2013, 201, 2, "skitter.tool"));
            result.Add(new TreeEntity(2014, 201, 2, "squish.tool"));
            result.Add(new TreeEntity(2021, 202, 1, "MyTool"));
            result.Add(new TreeEntity(2022, 202, 2, "skitter.tool"));
            result.Add(new TreeEntity(2023, 202, 2, "recharge.tool"));
            result.Add(new TreeEntity(20001, 2021, 2, "drat.tool"));
            result.Add(new TreeEntity(20002, 2021, 2, "opposite.tool"));
            result.Add(new TreeEntity(20003, 2021, 2, "phooey.tool"));

            return result;
        }
    }
}
