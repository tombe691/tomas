#include "unity.h"
#include "unity_fixture.h"

TEST_GROUP_RUNNER(ProductionCode)
{
  RUN_TEST_CASE(ProductionCode, FindFunction1);
  RUN_TEST_CASE(ProductionCode, FindFunction2);
  RUN_TEST_CASE(ProductionCode, Function3);
  RUN_TEST_CASE(ProductionCode, Function4);
  RUN_TEST_CASE(ProductionCode, Function5);
}
