
GO

/****** Object:  View [dbo].[QGlschstatmentnajat]    Script Date: 3/25/2017 10:58:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[QGlschstatmentnajat]
AS
SELECT        dbo.GLschstatment.jr_ty, dbo.GLschstatment.Tr_no, dbo.GLschstatment.Ln_No, dbo.GLschstatment.Acc_no, ISNULL(dbo.GLschstatment.tr_cr, 0) AS tr_cr, ISNULL(dbo.GLschstatment.Tr_db, 0) AS Tr_db, 
                         dbo.GLschstatment.Tr_Ds, dbo.GLschstatment.Tr_Dsc1, dbo.GLschstatment.Costcntr_No, dbo.GLschstatment.cstyp_NO, dbo.GLschstatment.cstyp_NO1, dbo.GLschstatment.CSMSUP_NO, 
                         dbo.Qsupcstmr.Cstm_Nm AS CSMSUP_Nm, dbo.GLschstatment.curno, dbo.GLschstatment.curprice, dbo.GLschstatment.curvalue, CONVERT(datetime, dbo.GLschstatment.Tr_Dt, 112) AS Tr_Dt, 
                         dbo.GLschstatment.branch, dbo.GLschstatment.acdcode, dbo.GLschstatment.FatherCode, dbo.GLmstrfl.Acc_Nm, dbo.GLmstrfl.Acc_Bnd, LEFT(dbo.GLmfband.parentid, 2) AS Acc_Mag, dbo.GLmfband.Acc_Bab, 
                         dbo.GLschstatment.schpaymenttypeid, ISNULL(dbo.GLschstatment.Tr_db, 0) - ISNULL(dbo.GLschstatment.tr_cr, 0) AS FinalBalance, dbo.schAcademicyear.AcademicYear, dbo.schAcademicyear.startdate, 
                         dbo.schAcademicyear.enddate, dbo.GLjrntyp.Jrty_Nme, dbo.GLjrntyp.Jrty_Nm, dbo.GLmfband.Acc_Nm AS babaccband, dbo.schpaymenttype.schpaymenttypenm, dbo.GLSubledgertyplist.SubledgerDescrption, 
                         dbo.GLschstatment.Dc_No, dbo.GLschstatment.foryearcode, dbo.schBranch.sgm, dbo.GLschstatment.Tr_Dt AS Expr1, dbo.GLschstatment.CSMSUP_Nm AS Expr2, dbo.GLschstatment.viewname, 
                         dbo.schBranch.Desc1, dbo.GLschstatment.approved, YEAR(dbo.GLschstatment.Tr_Dt) AS yeartrdt, MONTH(dbo.GLschstatment.Tr_Dt) AS Monthtrdt
FROM            dbo.GLmstrfl INNER JOIN
                         dbo.GLmfband ON dbo.GLmstrfl.Acc_Bnd = dbo.GLmfband.Acc_Bnd RIGHT OUTER JOIN
                         dbo.Qsupcstmr RIGHT OUTER JOIN
                         dbo.Stcurncy RIGHT OUTER JOIN
                         dbo.schBranch LEFT OUTER JOIN
                         dbo.glmulcmp ON dbo.schBranch.sgm = dbo.glmulcmp.sgmid RIGHT OUTER JOIN
                         dbo.GLschstatment ON dbo.schBranch.branch = dbo.GLschstatment.branch ON dbo.Stcurncy.Curncy_No = dbo.GLschstatment.curno ON dbo.Qsupcstmr.Cstm_No = dbo.GLschstatment.CSMSUP_NO AND 
                         dbo.Qsupcstmr.typ = dbo.GLschstatment.cstyp_NO LEFT OUTER JOIN
                         dbo.GLSubledgertyplist ON dbo.GLschstatment.cstyp_NO = dbo.GLSubledgertyplist.Subledgerid LEFT OUTER JOIN
                         dbo.schpaymenttype ON dbo.GLschstatment.schpaymenttypeid = dbo.schpaymenttype.schpaymenttypeid LEFT OUTER JOIN
                         dbo.GLjrntyp ON dbo.GLschstatment.jr_ty = dbo.GLjrntyp.Jr_Ty LEFT OUTER JOIN
                         dbo.schAcademicyear ON dbo.GLschstatment.acdcode = dbo.schAcademicyear.Code ON dbo.GLmstrfl.Acc_No = dbo.GLschstatment.Acc_no


GO

/****** Object:  View [dbo].[Fixnotcorrectdate]    Script Date: 3/25/2017 10:58:58 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Fixnotcorrectdate]
AS
SELECT        TOP (100) PERCENT dbo.QGlschstatment.viewname, dbo.QGlschstatment.Tr_Dt, dbo.QGlschstatment.branch, dbo.QGlschstatment.acdcode, dbo.schAcademicyear.Code, 
                         schAcademicyear_1.GlFinperiodID AS Expr1, dbo.schAcademicyear.GlFinperiodID, dbo.QGlschstatment.Tr_no, dbo.QGlschstatment.jr_ty, schAcademicyear_1.enddate, schAcademicyear_1.startdate, 
                         schAcademicyear_1.AcademicYear, dbo.QGlschstatment.Desc1, dbo.QGlschstatment.Jrty_Nm
FROM            dbo.QGlschstatment LEFT OUTER JOIN
                         dbo.schAcademicyear ON dbo.QGlschstatment.Tr_Dt <= dbo.schAcademicyear.enddate AND dbo.QGlschstatment.Tr_Dt >= dbo.schAcademicyear.startdate LEFT OUTER JOIN
                         dbo.schAcademicyear AS schAcademicyear_1 ON dbo.QGlschstatment.acdcode = schAcademicyear_1.Code
WHERE        (dbo.QGlschstatment.Tr_Dt > dbo.QGlschstatment.enddate) OR
                         (dbo.QGlschstatment.Tr_Dt < dbo.QGlschstatment.startdate)
ORDER BY dbo.QGlschstatment.Tr_Dt DESC

GO


