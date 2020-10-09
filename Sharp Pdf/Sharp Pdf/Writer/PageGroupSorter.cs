using System;
using System.Collections.Generic;
using System.Linq;
using SharpPdf.Page;

namespace SharpPdf.Writer
{
    internal class RootGrouper
    {
        private readonly PdfDocument _internalDocumentReference;

        public RootGrouper(PdfDocument document)
        {
            _internalDocumentReference = document;
        }

        public IEnumerable<PageGroup> GroupPages()
        {
            var pageGroups = GetGroupedPages(_internalDocumentReference._pages);

            foreach (var group in pageGroups)
            {
                yield return FromGroupingToPageGroup(group);
            }
        }

        private IEnumerable<IGrouping<PageGroupingResources, PdfPage>> GetGroupedPages(List<PdfPage> pages)
        {
            return pages.GroupBy(page => new PageGroupingResources());
        }

        private PageGroup FromGroupingToPageGroup(IGrouping<PageGroupingResources, PdfPage> pageGroup)
        {
            PageGroup group = new PageGroup();
            
            foreach (var page in pageGroup)
            {
                group.GroupedPages.Add(page);
            }

            return group;
        }
    }

    internal sealed class PageGroupingResources
    {
        public PdfPageRotation Rotation { get; set; }
        public PdfPageDimension Dimension { get; set; }
    }
}