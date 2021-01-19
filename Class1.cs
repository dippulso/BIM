using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using bim;
using System.Collections.Generic;
using static bim.Form1;

namespace bim
{
    [TransactionAttribute(TransactionMode.Manual)]
    public class Class1 : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document document = commandData.Application.ActiveUIDocument.Document;
            FilteredElementCollector elementCollector = new FilteredElementCollector(document);
            List<Element> elements1 = (List<Element>)new FilteredElementCollector(document, (document.ActiveView.Id)).ToElements();
            List<Elems> elems = new List<Elems>();
            Form1 form1 = new Form1();
            using (List<Element>.Enumerator enumerator = elements1.GetEnumerator())
            {
                while (enumerator.MoveNext())
                {
                    Element current = enumerator.Current;
                    string str = !(current.Name == "") && current.Name != null ? current.Name : "Без названия";
                    elems.Add(new Form1.Elems()
                    {
                        ID = current.Id,
                        name = str
                    });
                }
            }
            form1.ShowForm(elems);
            return (Result)0;
        }
    }
}
