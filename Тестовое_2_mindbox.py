from pyspark.sql import SparkSession

spark = SparkSession.builder.appName("product-category").getOrCreate()

products = spark.createDataFrame([
    {"productId": 1, "productName": "Product A"},
    {"productId": 2, "productName": "Product B"},
    {"productId": 3, "productName": "Product C"},
    {"productId": 4, "productName": "Product D"},
])

categories = spark.createDataFrame([
    {"categoryId": 1, "categoryName": "Category A"},
    {"categoryId": 2, "categoryName": "Category B"},
    {"categoryId": 3, "categoryName": "Category C"},
])

products_categories = spark.createDataFrame([
    {"productId": 1, "categoryId": 1},
    {"productId": 1, "categoryId": 2},
    {"productId": 2, "categoryId": 3},
    {"productId": 3, "categoryId": 2},
])

products.createOrReplaceTempView("products")
products.show()
categories.createOrReplaceTempView("categories")
categories.show()
products_categories.createOrReplaceTempView("products_categories")
products_categories.show()

result_df = spark.sql("""
    SELECT p.productName, c.categoryName
    FROM products p
    LEFT JOIN products_categories pc ON p.productId = pc.productId
    LEFT JOIN categories c ON pc.categoryId = c.categoryId
""")

result_df.show()
