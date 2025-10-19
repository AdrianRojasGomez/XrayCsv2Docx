using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Infrastructure
{
    public class DocxActionExporter
    {
        public void CreateNumberedListDoc(string docxPath, IEnumerable<string> actions, string title = null)
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

                // Definir numeración (1., 2., 3., …) a nivel 0
                var numberingPart = mainPart.AddNewPart<NumberingDefinitionsPart>();
                numberingPart.Numbering = new Numbering();

                const int abstractNumId = 1;
                const int numId = 1;

                var abstractNum = new AbstractNum(
                    new Level(
                        new NumberingFormat { Val = NumberFormatValues.Decimal }, // 1,2,3
                        new LevelText { Val = "%1." },                             // “1.”, “2.”, …
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

                // (Opcional) Título
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
    }
}
