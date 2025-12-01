--update stpurhdr   set acdcode=52  WHERE        (Doc_Dt BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2017-12-31 00:00:00', 102))
--update stpurhdr   set acdcode=51  WHERE        (Doc_Dt BETWEEN CONVERT(DATETIME, '2016-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-12-31 00:00:00', 102))
--update stpurhdr   set acdcode=50  WHERE        (Doc_Dt < CONVERT(DATETIME, '2016-01-01 00:00:00', 102)) 
--update stsalhdr   set acdcode=52  WHERE        (Doc_Dt BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2017-12-31 00:00:00', 102))
--update stsalhdr   set acdcode=51  WHERE        (Doc_Dt BETWEEN CONVERT(DATETIME, '2016-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-12-31 00:00:00', 102))
--update stsalhdr   set acdcode=50  WHERE        (Doc_Dt < CONVERT(DATETIME, '2016-01-01 00:00:00', 102)) 

--update gljrnvchhdr   set gljrnvchhdr.GlFinperiodID=52  WHERE        (gljrnvchhdr.Trs_Dt BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2017-12-31 00:00:00', 102))
--update gljrnvchhdr   set gljrnvchhdr.GlFinperiodID=51  WHERE        (gljrnvchhdr.Trs_Dt BETWEEN CONVERT(DATETIME, '2016-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-12-31 00:00:00', 102))
--update gljrnvchhdr   set gljrnvchhdr.GlFinperiodID=50  WHERE        (gljrnvchhdr.Trs_Dt < CONVERT(DATETIME, '2016-01-01 00:00:00', 102)) 

--update  gljrnvch set acdcode=52 where tr_no in (select tr_no from gljrnvchhdr where GlFinperiodID=52)
--update  gljrnvch set acdcode=51 where tr_no in (select tr_no from gljrnvchhdr where GlFinperiodID=51)
--update  gljrnvch set acdcode=50 where tr_no in (select tr_no from gljrnvchhdr where GlFinperiodID=50)


--update GLjrntrs   set acdcode=52  WHERE        (GLjrntrs.Tr_Dt BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2017-12-31 00:00:00', 102))
--update GLjrntrs   set acdcode=51  WHERE        (GLjrntrs.Tr_Dt BETWEEN CONVERT(DATETIME, '2016-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-12-31 00:00:00', 102))
--update GLjrntrs   set acdcode=50  WHERE        (GLjrntrs.Tr_Dt < CONVERT(DATETIME, '2016-01-01 00:00:00', 102)) 

--update GLjrntrsoth   set acdcode=52  WHERE        (GLjrntrsoth.Tr_Dt BETWEEN CONVERT(DATETIME, '2017-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2017-12-31 00:00:00', 102))
--update GLjrntrsoth   set acdcode=51  WHERE        (GLjrntrsoth.Tr_Dt BETWEEN CONVERT(DATETIME, '2016-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-12-31 00:00:00', 102))
--update GLjrntrsoth   set acdcode=50  WHERE        (GLjrntrsoth.Tr_Dt < CONVERT(DATETIME, '2016-01-01 00:00:00', 102)) 

----posted
--update gljrnvchhdr   set gljrnvchhdr.posted=1  WHERE        (gljrnvchhdr.Trs_Dt BETWEEN CONVERT(DATETIME, '2016-01-01 00:00:00', 102) AND CONVERT(DATETIME, '2016-12-31 00:00:00', 102))
--update gljrnvchhdr   set gljrnvchhdr.posted=1  WHERE        (gljrnvchhdr.Trs_Dt < CONVERT(DATETIME, '2016-01-01 00:00:00', 102)) 



