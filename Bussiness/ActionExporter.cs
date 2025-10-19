using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using Model;

namespace Bussiness
{
    public class ActionExporter
    {
        public void CreateNumberedListDoc(string docxPath, IEnumerable<string> actions, DocxHeader header, string title = null)
        {
            if (actions == null)
                throw new ArgumentNullException(nameof(actions));

            // Asegura que exista el directorio destino
            var dir = Path.GetDirectoryName(docxPath);
            if (!string.IsNullOrWhiteSpace(dir) && !Directory.Exists(dir))
                Directory.CreateDirectory(dir);

            using (var doc = WordprocessingDocument.Create(docxPath, WordprocessingDocumentType.Document))
            {
                // Partes principales
                var mainPart = doc.AddMainDocumentPart();
                mainPart.Document = new Document(new Body());
                var body = mainPart.Document.Body;

                // ===== Cabecera (una línea por campo) =====
                // Siempre mostrar los títulos; si hay valor, lo imprime a la derecha.
                AppendHeaderLine(body, "Environment", header?.Environment);
                AppendHeaderLine(body, "Date", header?.Date);
                AppendHeaderLine(body, "Site", header?.Site);
                AppendHeaderLine(body, "Credentials", header?.Credentials);
                AppendHeaderLine(body, "Tester Name", header?.TesterName);
                AppendHeaderLine(body, "JIRA Key", header?.JiraKey);

                
                body.Append(new Paragraph(new Run(new Text(string.Empty))));

                
                var numberingPart = mainPart.AddNewPart<NumberingDefinitionsPart>();
                numberingPart.Numbering = new Numbering();

                const int abstractNumId = 1;
                const int numId = 1;

                var abstractNum = new AbstractNum(
                    new Level(
                        new NumberingFormat { Val = NumberFormatValues.Decimal }, 
                        new LevelText { Val = "%1." },                             
                        new StartNumberingValue { Val = 1 }
                    )
                    { LevelIndex = 0 }
                )
                { AbstractNumberId = abstractNumId };

                numberingPart.Numbering.Append(abstractNum);

                var numberingInstance = new NumberingInstance(
                    new AbstractNumId { Val = abstractNumId }
                )
                { NumberID = numId };

                numberingPart.Numbering.Append(numberingInstance);

                // Título
                if (!string.IsNullOrWhiteSpace(title))
                {
                    body.Append(new Paragraph(new Run(new Text(title))));
                    body.Append(new Paragraph(new Run(new Text(string.Empty)))); // Espacio en blanco
                }

                // Ítems numerados
                foreach (var item in actions)
                {
                    var text = item ?? string.Empty;

                    var p = new Paragraph(
                        new ParagraphProperties(
                            new NumberingProperties(
                                new NumberingLevelReference { Val = 0 },
                                new NumberingId { Val = numId }
                            )
                        ),
                        new Run(new Text(text))
                    );

                    body.Append(p);
                }

                mainPart.Document.Save();
            }
        }

        private static void AppendHeaderLine(Body body, string label, string value)
        {
            var labelRun = new Run(
                new RunProperties(new Bold()),      // Negrita SOLO para el label
                new Text(label + ":")
            );

            // Un espacio y el valor (si viene null, queda vacío)
            var spaceRun = new Run(new Text(" "));
            var valueRun = new Run(new Text(value ?? string.Empty));

            var paragraph = new Paragraph(labelRun, spaceRun, valueRun);
            body.Append(paragraph);
        }
    }
}
