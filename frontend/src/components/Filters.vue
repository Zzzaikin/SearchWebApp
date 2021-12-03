



<template>
  <div class="filters">
    <v-radio-group row class="ml-6" v-model="hasPilotProject">
      <v-radio label="Нет пилотного проекта" :value="false"></v-radio>
      <v-radio label="Есть пилотный проект" :value="true"></v-radio>
    </v-radio-group>
    <div class="filters">
      <div class="filters-group" id="hasPilotProject" v-if="hasPilotProject">
        <div class="filter-label ml-5">
          <span>Заявка</span>
        </div>
        <v-row class="ma-0">
          <v-col>
            <v-select
              outlined
              multiplie
              class="filter mx-2"
              :items="[
                'Скрининг',
                'Скоринг',
                'Экспертный совет',
                'Акселерационная программа',
                'Программа пилотирования',
                'Инвестирование',
              ]"
              label="Стадия готовности"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              multiplie
              class="filter mx-2"
              :items="['Да', 'Нет']"
              label="Требуется ли сертификация продукта"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              multiplie
              class="filter mx-2"
              :items="['1-5', '6-10', '11-15', '16-20', '21-26', '27+']"
              label="Сколько человек в организации"
            ></v-select>
          </v-col>
        </v-row>
        <div class="filter-label ml-5">
          <span>Пилотный проект</span>
        </div>
        <v-row class="ma-0">
          <v-col>
            <v-select
              outlined
              multiplie
              class="filter mx-2"
              :items="['В работе', 'Приостановлен', 'Закрыт', 'Отменен']"
              label="Состояние проекта"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              multiplie
              class="filter mx-2"
              :items="[
                'Позиционирование в ОТКМ',
                'Детализация параметров пилотного тестирования',
                'Подготовка к пилотному тестированию',
                'Проведение пилотного тестирования',
                'Формирование отчёта пилотном тестировании',
                'Закрытие пилотного проекта',
                'Закрыт',
              ]"
              label="Фаза пилотного тестирования"
            ></v-select>
          </v-col>
        </v-row>
      </div>
      <div class="filters-group" id="doesntHasPilotProject" v-else>
        <div class="filter-label ml-5">
          <span>Заявка</span>
        </div>
        <v-row class="ma-0">
          <v-col>
            <v-select
              outlined
              class="filter mx-2"
              :items="items"
              :label="defaultLabel"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              class="filter mx-2"
              :items="items"
              :label="defaultLabel"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              class="filter mx-2"
              :items="items"
              :label="defaultLabel"
            ></v-select>
          </v-col>
          <v-col>
            <v-select
              outlined
              class="filter mx-2"
              :items="items"
              :label="defaultLabel"
            ></v-select>
          </v-col>
        </v-row>
      </div>
    </div>
    <div class="buttons pa-5">
      <v-row class="ma-0">
        <v-btn color="primary"> Применить </v-btn>
        <v-btn outlined class="ml-6"> Сбросить </v-btn>
      </v-row>
    </div>
  </div>
</template>

<script>
export default {
  data: () => ({
    hasPilotProject: false,
    items: ["Значение 1", "Значение 2", "Значение 3"],
    defaultLabel: "Фильтр",
  }),
};
</script>











