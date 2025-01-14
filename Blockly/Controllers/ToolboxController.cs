﻿using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace Blockly.Controllers
{
    public class ToolboxController : ApiController
    {
        [HttpGet]
        [Route("")]
        public HttpResponseMessage Get()
        {
            return new HttpResponseMessage()
            {
                Content = new StringContent(
                    "<category name=\"Logic\" colour=\"%{BKY_LOGIC_HUE}\">" +
                    "<block type=\"controls_if\"></block>" +
                    "<block type=\"controls_if\">" +
                    "<mutation else=\"1\"></mutation>" +
                    "</block>" +
                    "<block type=\"controls_if\">" +
                    "<mutation elseif=\"1\" else=\"1\"></mutation>" +
                    "</block></category>" +
                    "<category name=\"Boolean\" colour=\"%{BKY_LOGIC_HUE}\">" +
                    "<block type=\"logic_compare\"></block>" +
                    "<block type=\"logic_operation\"></block>" +
                    "<block type=\"logic_negate\"></block>" +
                    "<block type=\"logic_boolean\"></block>" +
                    "<block type=\"logic_null\"></block>" +
                    "<block type=\"logic_ternary\"></block>" +
                    "</category> " +
                    "<category name=\"Loops\" colour=\"%{BKY_LOOPS_HUE}\">" +
                    "<block type=\"controls_repeat_ext\">" +
                    "    <value name=\"TIMES\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">10</field>" +
                    "        </block>" +
                    "    </value>" +
                    "</block>" +
                    "<block type=\"controls_whileUntil\"></block>" +
                    "<block type=\"controls_for\">" +
                    "    <field name=\"VAR\">i</field>" +
                    "    <value name=\"FROM\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">1</field>" +
                    "        </block>" +
                    "    </value>" +
                    "    <value name=\"TO\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">10</field>" +
                    "        </block>" +
                    "    </value>" +
                    "    <value name=\"BY\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">1</field>" +
                    "        </block>" +
                    "    </value>" +
                    "</block>" +
                    "<block type=\"controls_forEach\"></block>" +
                    "<block type=\"controls_flow_statements\"></block>" +
                    "</category>" +
                    "<category name=\"Math\" colour=\"%{BKY_MATH_HUE}\">" +
                    "<block type=\"math_number\">" +
                    "    <field name=\"NUM\">123</field>" +
                    "</block>" +
                    "<block type=\"math_arithmetic\"></block>" +
                    "<block type=\"math_single\"></block>" +
                    "<block type=\"math_trig\"></block>" +
                    "<block type=\"math_constant\"></block>" +
                    "<block type=\"math_number_property\"></block>" +
                    "<block type=\"math_round\"></block>" +
                    "<block type=\"math_on_list\"></block>" +
                    "<block type=\"math_modulo\"></block>" +
                    "<block type=\"math_constrain\">" +
                    "    <value name=\"LOW\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">1</field>" +
                    "        </block>" +
                    "    </value>" +
                    "    <value name=\"HIGH\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">100</field>" +
                    "        </block>" +
                    "    </value>" +
                    "</block>" +
                    "<block type=\"math_random_int\">" +
                    "    <value name=\"FROM\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">1</field>" +
                    "        </block>" +
                    "    </value>" +
                    "    <value name=\"TO\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">100</field>" +
                    "        </block>" +
                    "    </value>" +
                    "</block>" +
                    "<block type=\"math_random_float\"></block>" +
                    "<block type=\"math_atan2\"></block>" +
                    "</category>" +
                    "<category name=\"Lists\" colour=\"%{BKY_LISTS_HUE}\">" +
                    "<block type=\"lists_create_empty\"></block>" +
                    "<block type=\"lists_create_with\"></block>" +
                    "<block type=\"lists_repeat\">" +
                    "    <value name=\"NUM\">" +
                    "        <block type=\"math_number\">" +
                    "            <field name=\"NUM\">5</field>" +
                    "        </block>" +
                    "    </value>" +
                    "</block>" +
                    "<block type=\"lists_length\"></block>" +
                    "<block type=\"lists_isEmpty\"></block>" +
                    "<block type=\"lists_indexOf\"></block>" +
                    "<block type=\"lists_getIndex\"></block>" +
                    "<block type=\"lists_setIndex\"></block>" +
                    "</category>" +
                    "<sep></sep>" +
                    "<category name=\"Variables\" custom=\"VARIABLE\" colour=\"%{BKY_VARIABLES_HUE}\">" +
                    "</category>" +
                    "<sep></sep>" +
                    "<category name=\"Valores\" colour=\"%{BKY_VARIABLES_HUE}\">" +
                    "<block type=\"from_a\"></block>" +
                    "<block type=\"from_b\"></block>" +
                    "<block type=\"from_c\"></block>" +
                    "<block type=\"form_set_s\"></block>" +
                    "</category>",
                    Encoding.UTF8,
                    "text/html")
            };
        }
    }
}
