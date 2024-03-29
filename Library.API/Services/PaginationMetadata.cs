﻿namespace Library.API.Services
{
    /// <summary>
    /// Represents metadata for pagination.
    /// </summary>
    public class PaginationMetadata
    {
        /// <summary>
        /// Gets or sets the total number of items across all pages.
        /// </summary>
        public int TotalItemCount { get; set; }

        /// <summary>
        /// Gets or sets the total number of pages based on the specified page size and total item count.
        /// </summary>
        public int TotalPageCount { get; set; }

        /// <summary>
        /// Gets or sets the number of items per page.
        /// </summary>
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or sets the current page number.
        /// </summary>
        public int CurrentPage { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationMetadata"/> class.
        /// </summary>
        /// <param name="totalItemCount">The total number of items across all pages.</param>
        /// <param name="pageSize">The number of items per page.</param>
        /// <param name="currentPage">The current page number.</param>
        public PaginationMetadata(int totalItemCount, int pageSize, int currentPage)
        {
            TotalItemCount = totalItemCount;
            PageSize = pageSize;
            CurrentPage = currentPage;
            TotalPageCount = (int)Math.Ceiling(totalItemCount / (double)pageSize);
        }
    }
}
