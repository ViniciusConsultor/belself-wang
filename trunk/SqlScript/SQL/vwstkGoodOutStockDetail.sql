ALTER VIEW dbo.vwstkGoodOutStockDetail
AS
SELECT A.*,B.sGoodCName, B.sGoodEName,
ISNULL(A.fSalePrice,0)*ISNULL(A.fQuantity,0)*ISNULL(A.fDiscount,0)/100 AS fAmount,
ISNULL(A.fSalePrice,0)*ISNULL(A.fQuantity,0)*(1-ISNULL(A.fDiscount,0)/100) AS fDiscountMoney
FROM stkGoodOutStockDetail A
LEFT JOIN salGoodInfoMaster B ON A.sGoodID=B.sGoodID
