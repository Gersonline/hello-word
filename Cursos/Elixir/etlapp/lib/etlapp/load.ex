defmodule Etlapp.Load do

  defmodule Loop do
    def print_multiple_times(orderlist, n) when n <= 1 do
      IO.inspect(orderlist)
      IO.puts n
    end

    def print_multiple_times(orderlist, n) do
      IO.inspect(orderlist)

      url = "http://challenge.dienekes.com.br/api/numbers?page=" <> Integer.to_string(n)

      response = HTTPotion.get!(url)
      result = Poison.Parser.parse response.body
      list = elem(result, 1)
      #numbers = Enum.at(list, 0)
      listnumbers = list["numbers"]
      newlist = Enum.sort(listnumbers)

       print_multiple_times(orderlist ++ newlist, n - 1)
    end
 end

  def create("ok") do

    url = "http://challenge.dienekes.com.br/api/numbers?page=1"

    response = HTTPotion.get!(url)
    result = Poison.Parser.parse response.body
    list = elem(result, 1)
    #numbers = Enum.at(list, 0)
    listnumbers = list["numbers"]
    orderlist = Enum.sort(listnumbers)

    newlist = Loop.print_multiple_times(orderlist, 20)

    #for n <- listnumbers, times <- length(listnumbers)..n, do: IO.inspect(listnumbers)




'''
    #req1 = Enum.at(req, 2)
    IO.inspect("============================BODY============")
    IO.inspect(response)
    IO.inspect(response.body)
    IO.inspect(result)
    IO.inspect(list)
    IO.inspect("============================numbers============")
   # IO.inspect(numbers)
    IO.inspect(listnumbers)
    IO.inspect(orderlist)
'''
    {:ok, %{ordernumbers: elem(newlist, 1)}}
  end

  def create("error") do
    {:ok, "Erro na ordenação"}
  end
end
