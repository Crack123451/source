public class Str {
    public static void main(String[] args) {
        StringBuilder result=new StringBuilder();
        String[] roles =new String[]{"Городничий",
                "Городничий #2",
                "Артемий Филиппович",
                "Лука Лукич"};
        String[] textLines =new String[]{"Городничий: Я пригласил вас, господа, с тем, чтобы сообщить вам пренеприятное известие: к нам едет ревизор.",
                "Городничий #2: Как ревизор?",
                "Артемий Филиппович: Как ревизор?",
                "Городничий: Ревизор из Петербурга, инкогнито. И еще с секретным предписаньем.",
                "Городничий #2: Вот те на!",
                "Артемий Филиппович: Вот не было заботы, так подай!",
                "Лука Лукич: Господи боже! еще и с секретным предписаньем!"};

        for(int i=0;i<roles.length;i++){
            roles[i]=roles[i]+":";
            result.append(roles[i]+'\n');
            for(int j=0;j<textLines.length;j++){
                    if( textLines[j].startsWith(roles[i]) )
                        result.append((j+1)+") "+textLines[j].substring(textLines[j].indexOf(":")+2)+'\n');
            }
            if(i!=roles.length-1)
                result.append('\n');
        }
        System.out.println(result.toString());

    }
}
