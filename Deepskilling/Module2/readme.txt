# E-commerce Platform Search Function

This project demonstrates two common searching techniques used in e-commerce platforms to locate products efficiently.

## Linear Search

Linear Search checks each product one by one until the desired product is found or the list ends. It is simple to implement and works on both sorted and unsorted data. However, its performance decreases as the number of products increases because it may need to examine every item in the collection.

**Time Complexity:** O(n)

### Advantages

* Easy to implement
* Works on unsorted data
* Suitable for small datasets

### Disadvantages

* Slower for large datasets
* Requires checking elements sequentially

## Binary Search

Binary Search works by repeatedly dividing a sorted collection into two halves and eliminating the half that cannot contain the target product. This significantly reduces the number of comparisons required and makes searching much faster for large datasets.

**Time Complexity:** O(log n)

### Advantages

* Very efficient for large datasets
* Requires fewer comparisons than Linear Search

### Disadvantages

* Data must be sorted before searching
* Slightly more complex to implement

## Conclusion

Both Linear Search and Binary Search are important searching algorithms. Linear Search is useful for small or unsorted datasets, while Binary Search provides much better performance when working with large, sorted product catalogs. In e-commerce platforms, Binary Search is often preferred when product data is maintained in sorted order, as it improves search efficiency and user experience.

