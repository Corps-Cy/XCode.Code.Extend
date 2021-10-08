using System;
using System.Collections.Generic;
using XCode.DataAccessLayer;

namespace XCode.Code.Extend
{
    /// <summary>
    /// Crops 扩展T4代码生成器
    /// </summary>
    public class EntityExtendBuilder: EntityBuilder
    {
        public static int Build()
        {
            IDictionary<string, string> atts;
            IList<IDataTable> tables = ClassBuilder.LoadModels(null, null, out atts);
            EntityBuilder.FixModelFile(null, null, atts, tables);
            return EntityBuilder.BuildTables(tables, null,true);
        }
        protected override void BuildBiz()
        {
            this.WriteLine("========测试操作==========");
            base.BuildBiz();
        }
    }
}
